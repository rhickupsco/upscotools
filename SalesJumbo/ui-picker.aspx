<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-picker.aspx.cs" Inherits="ui_picker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Pickers</h1>
					</div>
				</div>
			</div>
		</div>
		<div class="container">
			<div class="row">
				<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
					<section class="content-inner margin-top-no">
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p>Pickers provide a simple way to select a single value from a pre-determined set.</p>
									<p><span class="icon icon-lg text-brand-accent">info_outline</span> Only datepicker has been implemented at this moment.</p>
								</div>
							</div>
						</div>
						
							<h2 class="content-sub-heading">Examples</h2>
							
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example">A basic en example:</label>
											<input class="form-control" id="ui_datepicker_example_1" type="text">
											<p><span class="label label-brand-accent">Usage</span></p>
											<p>Activate the datepicker via simple javascript, for example: <code>$('#selector').pickdate();</code></p>
										</div>
<pre>
&lt;input class="form-control" id="selector" type="text"&gt;

$('#selector').pickdate();
</pre>
									</div>
								</div>
							</div>
							
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="DefaultDatepicker">default example:</label>
											<input class="form-control" id="DefaultDatepicker" type="text">
											<p><span class="label label-brand-accent">Usage</span></p>
											<p>
												Activate the datepicker via simple javascript, for example: 
												<code>$('#example').persianDatepicker({altField: '#defaultAlt';});</code>
											</p>
										</div>
<pre>
&lt;input class="form-control" id="example" type="text"&gt;

$('#example').persianDatepicker({
    altField: '#defaultAlt';
});
</pre>
									</div>
								</div>
							</div>
							
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_1">inline example:</label>
											
											<div id="inlineDatepicker" data-date="2016/12/13 12:20"></div>
											<p>&nbsp;</p>
											<input id="inlineDatepickerAlt" type="text" class="form-control"/>
											<p><span class="label label-brand-accent">Usage</span></p>
											<p>
												Activate the datepicker via simple javascript, for example: 
												<code>$("#inlineDatepicker").pDatepicker("setDate", [1391, 12, 1, 11, 14]);</code>
											</p>
										</div>
<pre>
&lt;input class="form-control" id="example" type="text"&gt;
&lt;div id="inlineDatepicker" data-date="2016/12/13 12:20"&gt; &lt;/div&gt;

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
</pre>
									</div>
								</div>
							</div>
							
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_1">sync with pasted data example:</label>
											
											<input id="observer" type="text" class="form-control"/>
											<input id="observerAlt" type="text" class="form-control"/>
											
											<p><span class="label label-brand-accent">Usage</span></p>
											<p>
												Activate the datepicker via simple javascript, for example: 
											</p>
										</div>
<pre>
&lt;input id="observer" type="text" class="form-control"/&gt;
&lt;input id="observerAlt" type="text" class="form-control"/&gt;

$("#observer").persianDatepicker({
	altField: '#observerAlt',
	altFormat: "YYYY MM DD HH:mm:ss",
	observer: true,
	format: 'YYYY/MM/DD'

});
</pre>
									</div>
								</div>
							</div>
							
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_1">Time Picker example:</label>
											
											<input id="timepicker" type="text" class="form-control"/>
											<input type="text" id="timepickerAltField" class="form-control"/>
											
											<p><span class="label label-brand-accent">Usage</span></p>
											<p>
												Activate the datepicker via simple javascript, for example: 
											</p>
										</div>
<pre>
&lt;input id="timepicker" type="text" class="form-control"/&gt;
&lt;input type="text" id="timepickerAltField" class="form-control"/&gt;

$("#timepicker").persianDatepicker({
	altField: '#timepickerAltField',
	altFormat: "YYYY MM DD HH:mm:ss",
	format: "HH:mm:ss a",
	onlyTimePicker: true
});
</pre>
									</div>
								</div>
							</div>
							
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_1">Month Picker example:</label>
											
											<input id="monthpicker" type="text" class="form-control"/>
											<input id="monthpickerAlt" type="text" class="form-control"/>
											
											<p><span class="label label-brand-accent">Usage</span></p>
											<p>
												Activate the datepicker via simple javascript, for example: 
											</p>
										</div>
<pre>
&lt;input id="monthpicker" type="text" class="form-control"/&gt;
&lt;input type="text" id="monthpickerAlt" class="form-control"/&gt;

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
</pre>
									</div>
								</div>
							</div>
							
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_1">Year Picker example:</label>
											
											<input id="yearpicker" type="text" class="form-control"/>
											<input id="yearpickerAlt" type="text" class="form-control"/>
											
											<p><span class="label label-brand-accent">Usage</span></p>
											<p>
												Activate the datepicker via simple javascript, for example: 
											</p>
										</div>
<pre>
&lt;input id="yearpicker" type="text" class="form-control"/&gt;
&lt;input type="text" id="yearpickerAlt" class="form-control"/&gt;

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
</pre>
									</div>
								</div>
							</div>
							
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_1">Year And Month Picker example:</label>
											
											<input id="yearAndMonthpicker" type="text" class="form-control"/>
											<input id="yearAndMonthpickerAlt" type="text" class="form-control"/>
											
											<p><span class="label label-brand-accent">Usage</span></p>
											<p>
												Activate the datepicker via simple javascript, for example: 
											</p>
										</div>
<pre>
&lt;input id="yearAndMonthpicker" type="text" class="form-control"/&gt;
&lt;input type="text" id="yearAndMonthpickerAlt" class="form-control"/&gt;

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
</pre>
									</div>
								</div>
							</div>
							
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_1">With Min and Max example:</label>
											
											<div id="inlineDatepickerWithMinMax"></div>
											<br/>
											<input id="inlineDatepickerWithMinMaxAlt" type="text" class=" form-control"/>
											
											<p><span class="label label-brand-accent">Usage</span></p>
											<p>
												Activate the datepicker via simple javascript, for example: 
											</p>
										</div>
<pre>
&lt;div id="inlineDatepickerWithMinMax"&gt;&lt;/div&gt;
&lt;input id="inlineDatepickerWithMinMaxAlt" type="text" class=" form-control"/&gt;

$("#inlineDatepickerWithMinMax").persianDatepicker({
	altField: '#inlineDatepickerWithMinMaxAlt',
	altFormat: "YYYY MM DD HH:mm:ss",
	minDate: 1416983467029,
	maxDate: 1419983467029
});
</pre>
									</div>
								</div>
							</div>
							
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_1">Custom Date Disabled example:</label>
											
											<div id="customDisabled"></div>
											<br/>
											<input id="customDisabledAlt" type="text" class=" form-control"/>
											
											<p><span class="label label-brand-accent">Usage</span></p>
											<p>
												Activate the datepicker via simple javascript, for example: 
											</p>
										</div>
<pre>
&lt;div id="customDisabled"&gt;&lt;/div&gt;
&lt;input id="customDisabledAlt" type="text" class=" form-control"/&gt;

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
</pre>
									</div>
								</div>
							</div>
							
							<h2 class="content-sub-heading">Options</h2>
							<p>Alternatively, options can be passed on to override some default datepicker behaviours.</p>
							<div class="table-responsive">
								<table class="table" title="Snackbar Options">
									<thead>
										<tr>
											<th>Option</th>
											<th>Description</th>
										</tr>
									</thead>
									<tbody>
										<tr>
											<td class="text-nowrap">cancel</td>
											<td>Change the text of the cancel button or use <code>cancel: ''</code> to hide the button. Default is <code>'Cancel'</code>.</td>
										</tr>
										<tr>
											<td class="text-nowrap">closeOnCancel</td>
											<td>Close the picker when the cancel button is clicked. Default is <code>true</code>. Set to <code>false</code> to change this behaviour.</td>
										</tr>
										<tr>
											<td class="text-nowrap">closeOnSelect</td>
											<td>Close the picker when a date is selected. Default is <code>false</code>. Set to <code>true</code> to change this behaviour.</td>
										</tr>
										<tr>
											<td class="text-nowrap">container</td>
											<td>Change where to insert the datepicker element by passing any valid CSS selector. Default is <code>'body'</code>. Set it to <code>''</code> to insert the picker right after the associated <code>input</code> element</td>
										</tr>
										<tr>
											<td class="text-nowrap">disable</td>
											<td>Disable a date or a set of dates from being selectable in the picker. See below for detailed usage.</td>
										</tr>
										<tr>
											<td class="text-nowrap">firstDay</td>
											<td>Change the first day of the week. Default is <code>0</code> which sets it to Sunday. Set it to Monday by changing the value to <code>1</code>.</td>
										</tr>
										<tr>
											<td class="text-nowrap">format</td>
											<td>Set the date format. See below for a full list of available date format rules.</td>
										</tr>
										<tr>
											<td class="text-nowrap">formatSubmit</td>
											<td>Optionally, set a different date format for the value to be submitted to the server. When <code>formatSubmit</code> is specified, a hidden <code>input</code> will be created to hold the value</td>
										</tr>
										<tr>
											<td class="text-nowrap">max</td>
											<td>Set the maximum selectable date.</td>
										</tr>
										<tr>
											<td class="text-nowrap">min</td>
											<td>Set the minimum selectable date.</td>
										</tr>
										<tr>
											<td class="text-nowrap">monthsFull</td>
											<td>Change labels of months.</td>
										</tr>
										<tr>
											<td class="text-nowrap">monthsShort</td>
											<td>Change abbreviations of months.</td>
										</tr>
										<tr>
											<td class="text-nowrap">ok</td>
											<td>Change the text of the OK button or set it to <code>''</code> to hide the button. Default is <code>'OK'</code>.</td>
										</tr>
										<tr>
											<td class="text-nowrap">onClose,<br>onOpen,<br>onRender,<br>onSet,<br>onStart,<br>onStop</td>
											<td>Fire events as the user interacts with the picker. Within scope of these events, <code>this</code> refers to the picker.</td>
										</tr>
										<tr>
											<td class="text-nowrap">selectMonths</td>
											<td>Default is <code>false</code>. Set it to <code>true</code> to display a dropdown menu to pick the month.</td>
										</tr>
										<tr>
											<td class="text-nowrap">selectYears</td>
											<td>Default is <code>false</code>. Set it to <code>true</code> to display a dropdown menu to pick the year or use an even integer to specify the number of years to be shown in the dropdown menu (half after and the other half before the year in focus).</td>
										</tr>
										<tr>
											<td class="text-nowrap">today</td>
											<td>Change the text of the today button or pass an empty value to hide the button: <code>today: ''</code>. Default is <code>'Today'</code>.</td>
										</tr>
										<tr>
											<td class="text-nowrap">weekdaysFull</td>
											<td>Change labels of weekdays.</td>
										</tr>
										<tr>
											<td class="text-nowrap">weekdaysShort</td>
											<td>Change abbreviations of weekdays.</td>
										</tr>
									</tbody>
								</table>
							</div>
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_2">A more advanced example</label>
											<input class="form-control" id="ui_datepicker_example_2" type="text">
										</div>
<pre>
$('#selector').pickdate({
    cancel: 'Clear',
    closeOnCancel: false,
    closeOnSelect: true,
    container: '',
    firstDay: 1,
    format: 'You selecte!d: dddd, d mm, yy', // escape any formatting characters with an exclamation mark
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
    }
    selectMonths: true,
    selectYears: 10,
    today: ''
});
</pre>
									</div>
								</div>
							</div>
							<div class="card">
								<div class="card-main">
									<div class="card-header">
										<div class="card-inner">
											<h3 class="card-heading">Disable</h3>
										</div>
									</div>
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_3">Using arrays formatted as <code>[YEAR,MONTH,DATE]</code></label>
											<input class="form-control" id="ui_datepicker_example_3" type="text" value="19/1/2016">
										</div>
<pre>
$('#selector').pickdate({
    disable: [
        [2016,0,12],
        [2016,0,13],
        [2016,0,14]
    ]
});
</pre>
										<div class="form-group">
											<label for="ui_datepicker_example_4">Using javascript dates</label>
											<input class="form-control" id="ui_datepicker_example_4" type="text" value="19/1/2016">
										</div>
<pre>
$('#selector').pickdate({
    disable: [
        new Date(2016,0,12),
        new Date(2016,0,13),
        new Date(2016,0,14)
    ]
});
</pre>
										<div class="form-group">
											<label for="ui_datepicker_example_5">Using numbers as days of the week (1 to 7)</label>
											<input class="form-control" id="ui_datepicker_example_5" type="text" value="19/1/2016">
										</div>
<pre>
$('#selector').pickdate({
    disable: [
        2, 4, 6
    ]
});
</pre>
										<div class="form-group">
											<label for="ui_datepicker_example_6">Using objects as a range of dates</label>
											<input class="form-control" id="ui_datepicker_example_6" type="text" value="19/1/2016">
										</div>
<pre>
$('#selector').pickdate({
    disable: [
        {
            from: [2016,0,12],
            to: 2
        }
    ]
});
</pre>
										<p>The values for <code>from</code> and <code>to</code> can be:</p>
										<ul>
											<li>Array formatted as <code>[YEAR,MONTH,DATE]</code> or javascript date object</li>
											<li>
												Integers representing dates relative to the other
												<ul>
													<li><code>from</code> can only be negative</li>
													<li><code>to</code> can only be positive</li>
												</ul>
											</li>
											<li>Use <code>true</code> to set it as today</li>
										</ul>
									</div>
								</div>
							</div>
							<div class="card">
								<div class="card-main">
									<div class="card-header">
										<div class="card-inner">
											<h3 class="card-heading">Disable with exceptions</h3>
										</div>
									</div>
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_7">Disable all with a set of exceptions</label>
											<input class="form-control" id="ui_datepicker_example_7" type="text" value="19/1/2016"></input>
										</div>
<pre>
$('#selector').pickdate({
    disable: [
        true,
        3,
        [2016,0,13],
        new Date(2016,0,14)
    ]
});
</pre>
										<div class="form-group">
											<label for="ui_datepicker_example_8">Enable dates that fall within a range of disabled dates by adding <code>inverted</code></label>
											<input class="form-control" id="ui_datepicker_example_8" type="text" value="19/1/2016"></input>
										</div>
<pre>
$('#selector').pickdate({
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
    ]
});
</pre>
									</div>
								</div>
							</div>
							<div class="card">
								<div class="card-main">
									<div class="card-header">
										<div class="card-inner">
											<h3 class="card-heading">Format</h3>
										</div>
									</div>
									<div class="card-inner margin-bottom-no">
										<p>The following rules can be used to format any date:</p>
										<div class="card-table">
											<div class="table-responsive">
												<table class="table" title="Snackbar Options">
													<thead>
														<tr>
															<th>Rule</th>
															<th>Description</th>
															<th>Result</th>
														</tr>
													</thead>
													<tbody>
														<tr>
															<td><code>d</code></td>
															<td>Date of the month</td>
															<td>1 – 31</td>
														</tr>
														<tr>
															<td><code>dd</code></td>
															<td>Date of the month with a leading zero</td>
															<td>01 – 31</td>
														</tr>
														<tr>
															<td><code>ddd</code></td>
															<td>Day of the week in short form</td>
															<td>Can be changed via changing <code>weekdaysShort</code>. Default is S - S.</td>
														</tr>
														<tr>
															<td><code>dddd</code></td>
															<td>Day of the week in full form</td>
															<td>Can be changed via changing <code>weekdaysFull</code>. Default is Sun - Sat.</td>
														</tr>
														<tr>
															<td><code>m</code></td>
															<td>Month of the year</td>
															<td>1 – 12</td>
														</tr>
														<tr>
															<td><code>mm</code></td>
															<td>Month of the year with a leading zero</td>
															<td>01 – 12</td>
														</tr>
														<tr>
															<td><code>mmm</code></td>
															<td>Month name in short form</td>
															<td>Can be changed via changing <code>monthsShort</code>. Default is Jan - Dec.</td>
														</tr>
														<tr>
															<td><code>mmmm</code></td>
															<td>Month name in full form</td>
															<td>Can be changed via changing <code>monthsFull</code>. Default is January – December.</td>
														</tr>
														<tr>
															<td><code>yy</code></td>
															<td>Year in short form</td>
															<td>00 – 99</td>
														</tr>
														<tr>
															<td><code>yyyy</code></td>
															<td>Year in full form</td>
															<td>2000 – 2999</td>
														</tr>
													</tbody>
												</table>
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class="card">
								<div class="card-main">
									<div class="card-header">
										<div class="card-inner">
											<h3 class="card-heading">Max/Min</h3>
										</div>
									</div>
									<div class="card-inner">
										<div class="form-group">
											<label for="ui_datepicker_example_9">Using arrays formatted as <code>[YEAR,MONTH,DATE]</code></label>
											<input class="form-control" id="ui_datepicker_example_9" type="text" value="19/1/2016">
										</div>
<pre>
$('#selector').pickdate({
    max: [2016,0,30],
    min: [2016,0,10]
});
</pre>
										<div class="form-group">
											<label for="ui_datepicker_example_10">Using javascript dates</code></label>
											<input class="form-control" id="ui_datepicker_example_10" type="text" value="19/1/2016">
										</div>
<pre>
$('#selector').pickdate({
    max: new Date(2016,0,30),
    min: new Date(2016,0,10)
});
</pre>
										<div class="form-group">
											<label for="ui_datepicker_example_10">Using a boolean or integers</code></label>
											<input class="form-control" id="ui_datepicker_example_11" type="text">
										</div>
<pre>
$('#selector').pickdate({
    max: true, // <code>true</code> sets it to today
    min: -10   // an integer (negative/positive) sets it relative to today
});
</pre>
									</div>
								</div>
							</div>
							<button class="access-hide" type="submit">Submit Button</button>
						
					</section>
				</div>
			</div>
		</div>
	</main>

	<script src="js/persian-date.js"></script>
	<script src="js/persian-datepicker-0.4.5.min.js"></script>

</asp:Content>

