<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-tab.aspx.cs" Inherits="ui_tab" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Tabs</h1>
					</div>
				</div>
			</div>
		</div>
		<div class="container">
			<div class="row">
				<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
					<section class="content-inner margin-top-no">
						<nav class="tab-nav ui-tab">
							<ul class="nav nav-list">
								<li class="active">
									<a class="waves-attach waves-light" data-toggle="tab" href=""><span class="text-white">First Tab</span></a>
								</li>
								<li>
									<a class="waves-attach waves-light" data-toggle="tab" href=""><span class="text-white">Second Tab</span></a>
								</li>
								<li>
									<a class="waves-attach waves-light" data-toggle="tab" href=""><span class="text-white">Third Tab</span></a>
								</li>
							</ul>
						</nav>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p>Tabs make it easy to explore and switch between different views or functional aspects of an app or to browse categorised data sets.</p>
									<p>Material uses Bootstrap's tab, please visit Bootstrap's documentation site for detailed usage.</p>
								</div>
								<div class="card-action">
									<div class="card-action-btn pull-right">
										<a class="btn btn-flat waves-attach" href="http://getbootstrap.com/javascript/#tabs" target="_blank">Bootstrap Tab<span class="icon margin-right-sm">open_in_new</span></a>
									</div>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Basic Tabs</h2>
						<div class="card">
							<div class="card-main">
								<nav class="tab-nav margin-top-no">
									<ul class="nav nav-justified">
										<li class="active">
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_1">First Tab</a>
										</li>
										<li>
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_2">Second Tab</a>
										</li>
										<li>
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_3">Third Tab</a>
										</li>
									</ul>
								</nav>
								<div class="card-inner">
									<div class="tab-content">
										<div class="tab-pane fade active in" id="ui_tab_example_1">
											<p>Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.</p>
										</div>
										<div class="tab-pane fade" id="ui_tab_example_2">
											<p>Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor.</p>
										</div>
										<div class="tab-pane fade" id="ui_tab_example_3">
											<p>Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.</p>
										</div>
									</div>
								</div>
							</div>
						</div>
<pre>
&lt;nav class="tab-nav"&gt;
    &lt;ul class="nav"&gt;
        &lt;li class="active"&gt;
            &lt;a data-toggle="tab" href="#selector"&gt; ... &lt;/a&gt;
        &lt;/li&gt;
        ...
    &lt;/ul&gt;
&lt;/nav&gt;
</pre>
						<h2 class="content-sub-heading">Coloured Tabs</h2>
						<div class="card">
							<div class="card-main">
								<nav class="tab-nav tab-nav-brand margin-top-no">
									<ul class="nav nav-justified">
										<li class="active">
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_1_brand">First Tab</a>
										</li>
										<li>
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_2_brand">Second Tab</a>
										</li>
										<li>
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_3_brand">Third Tab</a>
										</li>
									</ul>
								</nav>
								<div class="card-inner">
									<div class="tab-content">
										<div class="tab-pane fade active in" id="ui_tab_example_1_brand">
											<p><code>.tab-nav-brand</code></p>
										</div>
										<div class="tab-pane fade" id="ui_tab_example_2_brand">
											<p>Another Tab.</p>
										</div>
										<div class="tab-pane fade" id="ui_tab_example_3_brand">
											<p>Third Tab.</p>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<nav class="tab-nav tab-nav-green margin-top-no">
									<ul class="nav nav-justified">
										<li class="active">
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_1_green">First Tab</a>
										</li>
										<li>
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_2_green">Second Tab</a>
										</li>
										<li>
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_3_green">Third Tab</a>
										</li>
									</ul>
								</nav>
								<div class="card-inner">
									<div class="tab-content">
										<div class="tab-pane fade active in" id="ui_tab_example_1_green">
											<p><code>.tab-nav-green</code></p>
										</div>
										<div class="tab-pane fade" id="ui_tab_example_2_green">
											<p>Another Tab.</p>
										</div>
										<div class="tab-pane fade" id="ui_tab_example_3_green">
											<p>Third Tab.</p>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<nav class="tab-nav tab-nav-orange margin-top-no">
									<ul class="nav nav-justified">
										<li class="active">
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_1_orange">First Tab</a>
										</li>
										<li>
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_2_orange">Second Tab</a>
										</li>
										<li>
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_3_orange">Third Tab</a>
										</li>
									</ul>
								</nav>
								<div class="card-inner">
									<div class="tab-content">
										<div class="tab-pane fade active in" id="ui_tab_example_1_orange">
											<p><code>.tab-nav-orange</code></p>
										</div>
										<div class="tab-pane fade" id="ui_tab_example_2_orange">
											<p>Another Tab.</p>
										</div>
										<div class="tab-pane fade" id="ui_tab_example_3_orange">
											<p>Third Tab.</p>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<nav class="tab-nav tab-nav-red margin-top-no">
									<ul class="nav nav-justified">
										<li class="active">
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_1_red">First Tab</a>
										</li>
										<li>
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_2_red">Second Tab</a>
										</li>
										<li>
											<a class="waves-attach" data-toggle="tab" href="#ui_tab_example_3_red">Third Tab</a>
										</li>
									</ul>
								</nav>
								<div class="card-inner">
									<div class="tab-content">
										<div class="tab-pane fade active in" id="ui_tab_example_1_red">
											<p><code>.tab-nav-red</code></p>
										</div>
										<div class="tab-pane fade" id="ui_tab_example_2_red">
											<p>Another Tab.</p>
										</div>
										<div class="tab-pane fade" id="ui_tab_example_3_red">
											<p>Third Tab.</p>
										</div>
									</div>
								</div>
							</div>
						</div>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

