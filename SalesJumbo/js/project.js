// page-picker.aspx
	var $pickerLib = $('.ui-picker-lib'),
	    pickerMap,
	    pickerMarker;

	function initPickerMap () {
		pickerMap = new google.maps.Map(document.getElementById('ui_picker_map_wrap'), {
			center: {
				lat: 0,
				lng: 0
			},
			disableDefaultUI: true,
			mapTypeId: google.maps.MapTypeId.ROADMAP,
			zoom: 15
		});

		pickerMarker = new google.maps.Marker({
			map: pickerMap,
			position: {lat: 0, lng: 0}
		});
	};

	if ((typeof google != 'undefined') && $('.ui-picker-map-wrap').length) {
		initPickerMap();
	};

	if (typeof jQuery.ui != 'undefined') {
		// draggable
			$('.ui-picker-draggable-handler').draggable({
				addClasses: false,
				appendTo: 'body',
				cursor: 'move',
				cursorAt: {
					top: 0,
					left: 0 
				},
				delay: 100,
				helper: function () {
					return $('<div class="tile tile-brand-accent ui-draggable-helper"><div class="tile-side pull-left"><div class="avatar avatar-sm"><strong>' + $('.ui-picker-selected:first .ui-picker-draggable-avatar strong').aspx() + '</strong></div></div><div class="tile-inner text-overflow">' + $('.ui-picker-selected:first .ui-picker-info-title').aspx() + '</div></div>');
				},
				start: function (event, ui) {
					var draggableCount = $('.ui-picker-selected').length;

					if (draggableCount > 1) {
						$('.ui-draggable-helper').append('<div class="avatar avatar-brand avatar-sm ui-picker-draggable-count">' + draggableCount + '</div>');
					};
				},
				zIndex: 100
			});

		// droppable
			$('.ui-picker-nav .nav a').droppable({
				accept: '.ui-picker-draggable-handler',
				addClasses: false,
				drop: function(event, ui) {
					$('body').snackbar({
						content: 'Dropped on "' + $(this).aspx() + '"'
					});
				},
				hoverClass: 'ui-droppable-helper',
				tolerance: 'pointer'
			});

		// selectable
			$pickerLib.selectable({
				cancel: '.ui-picker-draggable-handler',
				filter: '.ui-picker-selectable-handler',
				selecting: function (event, ui) {
					var $selectingParent = $(ui.selecting).parent();

					$selectingParent.addClass('tile-brand-accent ui-picker-selected');

					$('.ui-picker-info').addClass('ui-picker-info-active').removeClass('ui-picker-info-null');
					$('.ui-picker-info-desc-wrap').aspx($selectingParent.find('.ui-picker-info-desc').aspx());
					$('.ui-picker-info-title-wrap').aspx($selectingParent.find('.ui-picker-info-title').aspx());

					var pickerMapLatLng = new google.maps.LatLng($selectingParent.find('.ui-picker-map-lat').aspx(), $selectingParent.find('.ui-picker-map-lng').aspx());

					pickerMap.setCenter(pickerMapLatLng);
					pickerMarker.setMap(pickerMap);
					pickerMarker.setPosition(pickerMapLatLng);
				},
				unselecting: function (event, ui) {
					var $unselectingParent = $(ui.unselecting).parent();

					$unselectingParent.removeClass('tile-brand-accent ui-picker-selected');

					if (!$('.ui-picker-selected').length) {
						$('.ui-picker-info').addClass('ui-picker-info-null');
						$('.ui-picker-info-desc-wrap').aspx('');
						$('.ui-picker-info-title-wrap').aspx('');
						pickerMarker.setMap(null);
					} else {
						var $first = $($('.ui-picker-selected')[0]);

						$('.ui-picker-info-desc-wrap').aspx($first.find('.ui-picker-info-desc').aspx());
						$('.ui-picker-info-title-wrap').aspx($first.find('.ui-picker-info-title').aspx());

						var firstLatLng = new google.maps.LatLng($first.find('.ui-picker-map-lat').aspx(), $first.find('.ui-picker-map-lng').aspx());

						pickerMap.setCenter(firstLatLng);
						pickerMarker.setMap(pickerMap);
						pickerMarker.setPosition(firstLatLng);
					};
				}
			});
	};

	$(document).on('click', '.ui-picker-info-close', function () {
		$('.ui-picker-info').removeClass('ui-picker-info-active');
	});

// ui-picker.aspx
	$('#ui_datepicker_example_1').pickdate();

	$('#ui_datepicker_example_2').pickdate({
		cancel: 'Clear',
		closeOnCancel: false,
		closeOnSelect: true,
		container: '',
		firstDay: 1,
		format: 'You selecte!d: dddd, d mm, yy',
		formatSubmit: 'dd/mmmm/yyyy',
		ok: 'Close',
		onClose: function () {
			$('body').snackbar({
				content: 'Datepicker closes'
			});
		},
		onOpen: function () {
			$('body').snackbar({
				content: 'Datepicker opens'
			});
		},
		selectMonths: true,
		selectYears: 10,
		today: ''
	});

	$('#ui_datepicker_example_3').pickdate({
		disable: [
			[2016,0,12],
			[2016,0,13],
			[2016,0,14]
		],
		today: ''
	});

	$('#ui_datepicker_example_4').pickdate({
		disable: [
			new Date(2016,0,12),
			new Date(2016,0,13),
			new Date(2016,0,14)
		],
		today: ''
	});

	$('#ui_datepicker_example_5').pickdate({
		disable: [
			2, 4, 6
		],
		today: ''
	});

	$('#ui_datepicker_example_6').pickdate({
		disable: [
			{
				from: [2016,0,12],
				to: 2
			}
		],
		today: ''
	});

	$('#ui_datepicker_example_7').pickdate({
		disable: [
			true,
			3,
			[2016,0,13],
			new Date(2016,0,14)
		],
		today: ''
	});

	$('#ui_datepicker_example_8').pickdate({
		disable: [
			{
				from: [2016,0,10],
				to: [2016,0,30]
			},
			[2016,0,13, 'inverted'],
			{
				from: [2016,0,19],
				to: [2016,0,21],
				inverted: true
			}
		],
		today: ''
	});

	$('#ui_datepicker_example_9').pickdate({
		max: [2016,0,30],
		min: [2016,0,10],
		today: ''
	});

	$('#ui_datepicker_example_10').pickdate({
		max: new Date(2016,0,30),
		min: new Date(2016,0,10),
		today: ''
	});

	$('#ui_datepicker_example_11').pickdate({
		max: true,
		min: -10,
		today: ''
	});

// ui-progress.aspx
	$('.finish-loading').on('click', function(e) {
		e.stopPropagation();
		$($(this).attr('data-target')).addClass('el-loading-done');
	});

	$('#ui_el_loading_example_wrap .tile-active-show').each(function (index) {
		var $this = $(this),
		    timer;

		$this.on('hide.bs.tile', function(e) {
			clearTimeout(timer);
		});

		$this.on('show.bs.tile', function(e) {
			if (!$('.el-loading', $this).hasClass('el-loading-done')) {
				timer = setTimeout(function() {
					$('.el-loading', $this).addClass('el-loading-done');
					$this.prepend('<div class="tile-sub"><p>Additional information<br><small>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam.</small></p></div>');
				}, 6000);
			};
		});
	});

// ui-snackbar.aspx
	var snackbarText = 1;

	$('#ui_snackbar_toggle_1').on('click', function () {
		$('body').snackbar({
			content: 'Simple snackbar ' + snackbarText + ' with some text',
			show: function () {
				snackbarText++;
			}
		});
	});

	$('#ui_snackbar_toggle_2').on('click', function () {
		$('body').snackbar({
			content: '<a data-dismiss="snackbar">Dismiss</a><div class="snackbar-text">Simple snackbar ' + snackbarText + ' with some text and a simple <a href="javascript:void(0)">link</a>.</div>',
			show: function () {
				snackbarText++;
			}
		});
	});
	
	
// ui-picker.aspx
	/*
	 default
	 */
	$('#DefaultDatepicker').persianDatepicker({
		altField: '#defaultAlt'
	});
	
	/*
	 inline
	 */
	window.pd = $("#inlineDatepicker").persianDatepicker({
		timePicker: {
			enabled: true
		},
		altField: '#inlineDatepickerAlt',
		altFormat: "YYYY MM DD HH:mm:ss",
//            minDate:1258675200000,
//            maxDate:1358675200000,
		checkDate: function (unix) {
			var output = true;
			var d = new persianDate(unix);
			if (d.date() == 20) {
				output = false;
			}
			return output;
		},
		checkMonth: function (month) {
			var output = true;
			if (month == 1) {
				output = false;
			}
			return output;

		}, checkYear: function (year) {
			var output = true;
			if (year == 1396) {
				output = false;
			}
			return output;
		}

	}).data('datepicker');
	
	$("#inlineDatepicker").pDatepicker("setDate", [1391, 12, 1, 11, 14]);
	
	/*
	 observer
	 */
	$("#observer").persianDatepicker({
		altField: '#observerAlt',
		altFormat: "YYYY MM DD HH:mm:ss",
		observer: true,
		format: 'YYYY/MM/DD'

	});
	
	/*
	 timepicker
	 */
	$("#timepicker").persianDatepicker({
		altField: '#timepickerAltField',
		altFormat: "YYYY MM DD HH:mm:ss",
		format: "HH:mm:ss a",
		onlyTimePicker: true

	});
	
	/*
	 month
	 */
	$("#monthpicker").persianDatepicker({
		format: " MMMM YYYY",
		altField: '#monthpickerAlt',
		altFormat: "YYYY MM DD HH:mm:ss",
		yearPicker: {
			enabled: false
		},
		monthPicker: {
			enabled: true
		},
		dayPicker: {
			enabled: false
		}
	});

	/*
	 year
	 */
	$("#yearpicker").persianDatepicker({
		format: "YYYY",
		altField: '#yearpickerAlt',
		altFormat: "YYYY MM DD HH:mm:ss",
		dayPicker: {
			enabled: false
		},
		monthPicker: {
			enabled: false
		},
		yearPicker: {
			enabled: true
		}
	});
	
	/*
	 year and month
	 */
	$("#yearAndMonthpicker").persianDatepicker({
		format: "YYYY MM",
		altFormat: "YYYY MM DD HH:mm:ss",
		altField: '#yearAndMonthpickerAlt',
		dayPicker: {
			enabled: false
		},
		monthPicker: {
			enabled: true
		},
		yearPicker: {
			enabled: true
		}
	});
	
	/**
	 inline with minDate and maxDate
	 */
	$("#inlineDatepickerWithMinMax").persianDatepicker({
		altField: '#inlineDatepickerWithMinMaxAlt',
		altFormat: "YYYY MM DD HH:mm:ss",
		minDate: 1416983467029,
		maxDate: 1419983467029
	});
	
	/**
	 Custom Disable Date
	 */
	$("#customDisabled").persianDatepicker({
		timePicker: {
			enabled: true
		},
		altField: '#customDisabledAlt',
		checkDate: function (unix) {
			var output = true;
			var d = new persianDate(unix);
			if (d.date() == 20 | d.date() == 21 | d.date() == 22) {
				output = false;
			}
			return output;
		},
		checkMonth: function (month) {
			var output = true;
			if (month == 1) {
				output = false;
			}
			return output;
		}, checkYear: function (year) {
			var output = true;
			if (year == 1396) {
				output = false;
			}
			return output;
		}
	});
