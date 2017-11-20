<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ui-nav-drawer.aspx.cs" Inherits="ui_nav_drawer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta charset="UTF-8">
	<meta content="IE=edge" http-equiv="X-UA-Compatible">
	<meta content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no, width=device-width" name="viewport">
	<title>Material</title>

	<!-- css -->
	<link href="../css/base.css" rel="stylesheet">
	<link href="../css/project.css" rel="stylesheet">
	
	<!-- favicon -->
	<!-- ... -->
</head>
<body class="page-brand">
	<nav class="menu menu-right nav-drawer nav-drawer-md" id="ui_menu">
		<div class="menu-scroll">
			<div class="menu-content">
				<a class="menu-logo" href="index.aspx">متریال</a>
				<ul class="nav">
					<li>
						<a class="waves-attach" data-toggle="collapse" href="#ui_menu_components">کامپوننت ها</a>
						<ul class="menu-collapse collapse in" id="ui_menu_components">
							<li>
								<a class="padding-right-lg waves-attach" href="ui-button.aspx">Buttons</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-button-fab.aspx">Buttons<small class="margin-left-xs">(Floating Action Button)</small></a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-card.aspx">Cards</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-data-table.aspx">Data Tables</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-dialog.aspx">Dialogs</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-dropdown-menu.aspx">Menus</a>
							</li>
							<li class="active">
								<a class="padding-right-lg waves-attach" href="ui-nav-drawer.aspx">Navigation Drawers</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-picker.aspx">Pickers</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-progress.aspx">Progress</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-selection-control.aspx">Selection Controls</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-snackbar.aspx">Snackbars</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-stepper.aspx">Steppers</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-tab.aspx">Tabs</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-text-field.aspx">Text Fields</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-toolbar.aspx">Toolbars</a>
							</li>
						</ul>
					</li>
					<li>
						<a class="collapsed waves-attach" data-toggle="collapse" href="#ui_menu_extras">Extras</a>
						<ul class="menu-collapse collapse" id="ui_menu_extras">
							<li>
								<a class="padding-right-lg waves-attach" href="ui-avatar.aspx">Avatars</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-icon.aspx">Icons</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-label.aspx">Labels</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-nav.aspx">Navs</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-tile.aspx">Tiles</a>
							</li>
						</ul>
					</li>
					<li>
						<a class="collapsed waves-attach" data-toggle="collapse" href="#ui_menu_javascript">Javascript</a>
						<ul class="menu-collapse collapse" id="ui_menu_javascript">
							<li>
								<a class="padding-right-lg waves-attach" href="ui-affix.aspx">Affix</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-collapse.aspx">Collapse</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-dropdown-menu.aspx">Dropdown</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-modal.aspx">Modals</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="ui-tab.aspx">Togglable Tabs</a>
							</li>
						</ul>
					</li>
					<li>
						<a class="collapsed waves-attach" data-toggle="collapse" href="#ui_menu_samples">Sample Pages</a>
						<ul class="menu-collapse collapse" id="ui_menu_samples">
							<li>
								<a class="padding-right-lg waves-attach" href="page-login.aspx">Login Page</a>
							</li>
							<li>
								<a class="padding-right-lg waves-attach" href="page-picker.aspx">Picker Page</a>
							</li>
						</ul>
					</li>
				</ul>
			</div>
		</div>
	</nav>
	<header class="header header-transparent header-waterfall ui-header">
		<ul class="nav nav-list pull-left hidden-md hidden-lg">
			<li>
				<a data-toggle="menu" href="#ui_menu">
					<span class="icon icon-lg">menu</span>
				</a>
			</li>
		</ul>
		<a class="header-logo header-affix-hide margin-left-no margin-right-no hidden-md hidden-lg" data-offset-top="213" data-spy="affix" href="index.aspx">Material</a>
		<span class="header-logo header-affix hidden-md hidden-lg margin-left-no margin-right-no" data-offset-top="213" data-spy="affix">Nav Drawers</span>
		<span class="header-logo header-affix visible-md-block visible-lg-block margin-right-no" data-offset-top="213" data-spy="affix">Nav Drawers</span>
		<ul class="nav nav-list pull-left">
			<li>
				<a data-toggle="menu" href="#ui_menu_profile">
					<span class="access-hide">John Smith</span>
					<span class="avatar avatar-sm"><img alt="alt text for John Smith avatar" src="../images/users/avatar-001.jpg"></span>
				</a>
			</li>
		</ul>
	</header>
	<nav aria-hidden="true" class="menu menu-left" id="ui_menu_profile" tabindex="-1">
		<div class="menu-scroll">
			<div class="menu-top">
				<div class="menu-top-img">
					<img alt="John Smith" src="../images/samples/landscape.jpg">
				</div>
				<div class="menu-top-info">
					<a class="menu-top-user" href="javascript:void(0)"><span class="avatar avatar-inline margin-left"><img alt="alt text for John Smith avatar" src="../images/users/avatar-001.jpg"></span>John Smith</a>
				</div>
				<div class="menu-top-info-sub">
					<small>Some additional information about John Smith</small>
				</div>
			</div>
			<div class="menu-content">
				<ul class="nav">
					<li>
						<a class="waves-attach" href="javascript:void(0)">
							Profile Settings
							<span class="menu-collapse-toggle collapsed waves-attach" data-target="#ui_menu_profile_settings" data-toggle="collapse">
								<div class="menu-collapse-toggle-close">
									<i class="icon icon-lg">close</i>
								</div>
								<div class="menu-collapse-toggle-default">
									<i class="icon icon-lg">add</i>
								</div>
							</span>
						</a>
						<ul class="menu-collapse collapse" id="ui_menu_profile_settings">
							<li>
								<a class="waves-attach" href="javascript:void(0)">First Item</a>
							</li>
							<li>
								<a class="waves-attach" href="javascript:void(0)">Another Item</a>
							</li>
							<li>
								<a class="waves-attach" href="javascript:void(0)">Something Else</a>
							</li>
						</ul>
					</li>
					<li>
						<a class="waves-attach" href="javascript:void(0)">Upload Photo</a>
					</li>
					<li>
						<a class="waves-attach" href="page-login.aspx">Logout</a>
					</li>
				</ul>
			</div>
		</div>
	</nav>
	<main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-10 col-md-offset-1">
						<h1 class="content-heading">Navigation Drawers</h1>
					</div>
				</div>
			</div>
		</div>
		<div class="container">
			<div class="row">
				<div class="col-lg-6 col-lg-offset-3 col-md-10 col-md-offset-1">
					<section class="content-inner margin-top-no">
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p>The navigation drawer slides in from the left. It is a common pattern found in Google apps and sites.</p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Examples</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Permanent</h3>
									</div>
								</div>
								<div class="card-inner">
									<p>The navigation drawer on the left is a live demo of a permanent navigation drawer. Permanent navigation drawers are always visible and pinned to the left edge.</p>
									<p><strong>N.B.</strong> Permanent navigation drawers are recommended for desktop, they will turn into temporary navigation drawers on mobile and tablets.</p>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Temporary</h3>
									</div>
								</div>
								<div class="card-inner">
									<p>The navigation drawer on the right is a live demo of a temporary navigation drawer. Temporary navigation drawers can toggle open or closed. Closed by default, the drawer opens temporarily above all other content until a section is selected.</p>
								</div>
							</div>
						</div>
					</section>
				</div>
			</div>
		</div>
	</main>
	<footer class="ui-footer">
		<div class="container">
			<p>Material</p>
		</div>
	</footer>
	<div class="fbtn-container">
		<div class="fbtn-inner">
			<a class="fbtn fbtn-lg fbtn-brand-accent waves-attach waves-circle waves-light" data-toggle="dropdown"><span class="fbtn-text fbtn-text-right">Links</span><span class="fbtn-ori icon">apps</span><span class="fbtn-sub icon">close</span></a>
			<div class="fbtn-dropup">
				<a class="fbtn waves-attach waves-circle" href="https://github.com/shoae/SalesJumbo" target="_blank"><span class="fbtn-text fbtn-text-right">Fork me on GitHub</span><span class="icon">code</span></a>
				<a class="fbtn fbtn-brand waves-attach waves-circle waves-light" href="http://dev62.com" target="_blank"><span class="fbtn-text fbtn-text-right">dev62.com</span><span class="icon">share</span></a>
				<a class="fbtn fbtn-green waves-attach waves-circle" href="https://shoae.github.io/SalesJumbo/" target="_blank"><span class="fbtn-text fbtn-text-right">Visit SalesJumbo</span><span class="icon">link</span></a>
			</div>
		</div>
	</div>

	<!-- js -->
	<script src="../js/jquery.min.2.2.0.js"></script>
	<script src="../js/base.js"></script>
	<script src="../js/project.js"></script>
</body>
</html>