<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-dropdown-menu.aspx.cs" Inherits="ui_dropdown_menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Dropdown Menus</h1>
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
									<p>Dropdown menus allow users to take an action by selecting from a list of choices revealed upon opening a temporary, new sheet of material.</p>
									<p>Material uses Bootstrap's dropdown, please visit Bootstrap's documentation site for detailed usage.</p>
								</div>
								<div class="card-action">
									<div class="card-action-btn pull-right">
										<a class="btn btn-flat waves-attach" href="http://getbootstrap.com/javascript/#dropdowns" target="_blank">Bootstrap Dropdown<span class="icon margin-right-sm">open_in_new</span></a>
									</div>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Examples</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p>Toggle dropdown menus by clicking the links below.</p>
									<p>In addition, clicking on the user avatar in the top right hand corner of the page can also trigger a dropdown menu.</p>
								</div>
								<div class="card-action">
									<ul class="nav nav-list margin-no pull-left">
										<li class="dropdown">
											<a class="dropdown-toggle text-black waves-attach" data-toggle="dropdown"><span class="icon">more_vert</span></a>
											<ul class="dropdown-menu">
												<li>
													<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">loop</span>&nbsp;Lorem Ipsum</a>
												</li>
												<li>
													<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">replay</span>&nbsp;Consectetur Adipiscing</a>
												</li>
												<li>
													<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">shuffle</span>&nbsp;Sed Ornare</a>
												</li>
											</ul>
										</li>
									</ul>
									<ul class="nav nav-list margin-no pull-right">
										<li class="dropdown">
											<a class="dropdown-toggle text-black waves-attach" data-toggle="dropdown"><span class="icon">more_vert</span></a>
											<ul class="dropdown-menu dropdown-menu-right">
												<li>
													<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">loop</span>&nbsp;Lorem Ipsum</a>
												</li>
												<li>
													<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">replay</span>&nbsp;Consectetur Adipiscing</a>
												</li>
												<li>
													<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">shuffle</span>&nbsp;Sed Ornare</a>
												</li>
											</ul>
										</li>
									</ul>
								</div>
							</div>
						</div>
<pre>
&lt;li class="dropdown"&gt;
    &lt;a class="dropdown-toggle" data-toggle="dropdown"&gt; ... &lt;/a&gt;
    &lt;ul class="dropdown-menu"&gt;
        &lt;li&gt;
            &lt;a&gt; ... &lt;/a&gt;
        &lt;/li&gt;
    &lt;/ul&gt;
&lt;/li&gt;
</pre>
						<div class="dropdown-wrap">
							<div class="dropdown dropdown-inline">
								<a class="btn dropdown-toggle-btn waves-attach" data-toggle="dropdown">Button Dropdown Menu<span class="icon margin-right-sm">keyboard_arrow_down</span></a>
								<ul class="dropdown-menu nav">
									<li>
										<a class="waves-attach" href="javascript:void(0)">Lorem Ipsum</a>
									</li>
									<li>
										<a class="waves-attach" href="javascript:void(0)">Consectetur Adipiscing</a>
									</li>
									<li>
										<a class="waves-attach" href="javascript:void(0)">Sed Ornare</a>
									</li>
								</ul>
							</div>
						</div>
<pre>
&lt;div class="dropdown-wrap"&gt;
    &lt;div class="dropdown dropdown-inline"&gt;
        &lt;a class="btn dropdown-toggle-btn" data-toggle="dropdown"&gt; ... &lt;/a&gt;
        &lt;ul class="dropdown-menu nav"&gt;
            &lt;li&gt;
                &lt;a&gt; ... &lt;/a&gt;
            &lt;/li&gt;
        &lt;/ul&gt;
    &lt;/div&gt;
&lt;/div&gt;
</pre>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

