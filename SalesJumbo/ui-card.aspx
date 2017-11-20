<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-card.aspx.cs" Inherits="ui_card" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<h1 class="content-heading">Cards</h1>
			</div>
		</div>
		<div class="container">
			<section class="content-inner margin-top-no">
				<div class="row">
					<div class="col-lg-8 col-md-9">
						<div class="card margin-bottom-no">
							<div class="card-main">
								<div class="card-inner">
									<p>A card is a sheet of material that serves as an entry point to more detailed information. A card could contain a photo, text, and a link about a single subject.</p>
								</div>
							</div>
						</div>
					</div>
				</div>
				<h2 class="content-sub-heading">Basic Cards</h2>
				<div class="ui-card-wrap">
					<div class="row">
						<div class="col-lg-4 col-sm-6">
							<div class="card">
								<div class="card-main">
									<div class="card-inner">
										<p class="card-heading">Default Card</p>
										<p>
											Lorem ipsum dolor sit amet.<br>
											Consectetur adipiscing elit.
										</p>
									</div>
									<div class="card-action">
										<div class="card-action-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;Button</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-sm-6">
<pre class="margin-top-no ui-card-pre">
&lt;div class="card"&gt;
    &lt;div class="card-main"&gt;
        &lt;div class="card-inner"&gt; ... &lt;/div&gt;
        &lt;div class="card-action"&gt; ... &lt;/div&gt;
    &lt;/div&gt;
&lt;/div&gt;
</pre>
						</div>
					</div>
				</div>
				<h3 class="h5">Brand Colours</h3>
				<div class="ui-card-wrap">
					<div class="row">
						<div class="col-lg-4 col-sm-6">
							<div class="card card-brand">
								<div class="card-main">
									<div class="card-inner">
										<p class="card-heading">Brand</p>
										<p>
											Lorem ipsum dolor sit amet.<br>
											Consectetur adipiscing elit.
										</p>
									</div>
									<div class="card-action">
										<div class="card-action-btn pull-right">
											<a class="btn btn-flat waves-attach waves-light" href="javascript:void(0)"><span class="icon">check</span>&nbsp;Button</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-sm-6">
<pre class="margin-top-no ui-card-pre">
&lt;div class="card card-brand"&gt;
    &lt;div class="card-main"&gt;
        &lt;div class="card-inner"&gt; ... &lt;/div&gt;
        &lt;div class="card-action"&gt; ... &lt;/div&gt;
    &lt;/div&gt;
&lt;/div&gt;
</pre>
						</div>
					</div>
				</div>
				<div class="ui-card-wrap">
					<div class="row">
						<div class="col-lg-4 col-sm-6">
							<div class="card card-brand-accent">
								<div class="card-main">
									<div class="card-inner">
										<p class="card-heading">Brand Accent</p>
										<p>
											Lorem ipsum dolor sit amet.<br>
											Consectetur adipiscing elit.
										</p>
									</div>
									<div class="card-action">
										<div class="card-action-btn pull-right">
											<a class="btn btn-flat waves-attach waves-light" href="javascript:void(0)"><span class="icon">check</span>&nbsp;Button</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-sm-6">
<pre class="margin-top-no ui-card-pre">
&lt;div class="card card-brand-accent"&gt;
    &lt;div class="card-main"&gt;
        &lt;div class="card-inner"&gt; ... &lt;/div&gt;
        &lt;div class="card-action"&gt; ... &lt;/div&gt;
    &lt;/div&gt;
&lt;/div&gt;
</pre>
						</div>
					</div>
				</div>
				<h3 class="h5">Colour Palettes</h3>
				<div class="ui-card-wrap">
					<div class="row">
						<div class="col-md-4 col-sm-6">
							<div class="card card-green">
								<div class="card-main">
									<div class="card-inner">
										<p class="card-heading">.card-green</p>
										<p>
											Lorem ipsum dolor sit amet.<br>
											Consectetur adipiscing elit.
										</p>
									</div>
									<div class="card-action">
										<div class="card-action-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;Button</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-md-4 col-sm-6">
							<div class="card card-orange">
								<div class="card-main">
									<div class="card-inner">
										<p class="card-heading">.card-orange</p>
										<p>
											Lorem ipsum dolor sit amet.<br>
											Consectetur adipiscing elit.
										</p>
									</div>
									<div class="card-action">
										<div class="card-action-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;Button</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-md-4 col-sm-6">
							<div class="card card-red">
								<div class="card-main">
									<div class="card-inner">
										<p class="card-heading">.card-red</p>
										<p>
											Lorem ipsum dolor sit amet.<br>
											Consectetur adipiscing elit.
										</p>
									</div>
									<div class="card-action">
										<div class="card-action-btn pull-right">
											<a class="btn btn-flat waves-attach waves-light" href="javascript:void(0)"><span class="icon">check</span>&nbsp;Button</a>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				<h2 class="content-sub-heading">Media Area</h2>
				<div class="ui-card-wrap">
					<div class="row">
						<div class="col-lg-4 col-sm-6">
							<div class="card">
								<div class="card-main">
									<div class="card-header">
										<div class="card-header-side margin-right">
											<div class="avatar">
												<img alt="John Smith Avatar" src="../images/users/avatar-001.jpg">
											</div>
										</div>
										<div class="card-inner">
											<span class="card-heading">Some Text!</span>
										</div>
									</div>
									<div class="card-img">
										<img alt="alt text" src="../images/samples/landscape.jpg" style="width: 100%;">
										<p class="card-img-heading">Some Text!</p>
									</div>
									<div class="card-inner">
										<p>
											Lorem ipsum dolor sit amet.<br>
											Consectetur adipiscing elit.
										</p>
									</div>
									<div class="card-action">
										<div class="card-action-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;Button</a>
										</div>
										<ul class="nav nav-list margin-no pull-left">
											<li class="dropdown">
												<a class="dropdown-toggle text-black waves-attach" data-toggle="dropdown"><span class="icon">keyboard_arrow_down</span></a>
												<ul class="dropdown-menu dropdown-menu-left">
													<li>
														<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">filter_1</span>&nbsp;Lorem Ipsum</a>
													</li>
													<li>
														<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">filter_2</span>&nbsp;Consectetur Adipiscing</a>
													</li>
													<li>
														<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">filter_3</span>&nbsp;Sed Ornare</a>
													</li>
												</ul>
											</li>
										</ul>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-sm-6">
<pre class="margin-top-no ui-card-pre ui-card-pre-media">
&lt;div class="card"&gt;
    &lt;div class="card-main"&gt;
        &lt;div class="card-header"&gt;
            ...
            &lt;div class="card-inner"&gt; ... &lt;/div&gt;
        &lt;/div&gt;
        &lt;div class="card-img"&gt;
            ...
            &lt;p class="card-img-heading"&gt; ... &lt;/p&gt;
        &lt;/div&gt;
        &lt;div class="card-inner"&gt; ... &lt;/div&gt;
        &lt;div class="card-action"&gt; ... &lt;/div&gt;
    &lt;/div&gt;
&lt;/div&gt;
</pre>
						</div>
					</div>
				</div>
				<h2 class="content-sub-heading">Vertical Area</h2>
				<div class="ui-card-wrap">
					<div class="row">
						<div class="col-lg-4 col-sm-6">
							<div class="card">
								<aside class="card-side pull-left">
									<span class="card-heading"><i class="icon">info_outline</i></span>
								</aside>
								<div class="card-main">
									<div class="card-inner">
										<p class="card-heading">Primary Area!</p>
										<p>
											Lorem ipsum dolor sit amet.<br>
											Consectetur adipiscing elit.
										</p>
									</div>
									<div class="card-action">
										<div class="card-action-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;Button</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-sm-6">
<pre class="margin-top-no ui-card-pre">
&lt;div class="card"&gt;
    &lt;aside class="card-side pull-left"&gt; ... &lt;/aside&gt;
    &lt;div class="card-main"&gt; ... &lt;/div&gt;
&lt;/div&gt;
</pre>
						</div>
					</div>
				</div>
				<div class="ui-card-wrap">
					<div class="row">
						<div class="col-lg-4 col-sm-6">
							<div class="card">
								<a class="card-side pull-right waves-attach" href="javascript:void(0)"><span class="card-heading">Button</span></a>
								<div class="card-main">
									<div class="card-inner">
										<p class="card-heading">Primary Area!</p>
										<p class="margin-bottom-lg">
											Lorem ipsum dolor sit amet.<br>
											Consectetur adipiscing elit.
										</p>
									</div>
									<div class="card-action">
										<ul class="nav nav-list margin-no pull-right">
											<li class="dropdown">
												<a class="dropdown-toggle text-black waves-attach" data-toggle="dropdown"><span class="icon">keyboard_arrow_down</span></a>
												<ul class="dropdown-menu dropdown-menu-right">
													<li>
														<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">filter_1</span>&nbsp;Lorem Ipsum</a>
													</li>
													<li>
														<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">filter_2</span>&nbsp;Consectetur Adipiscing</a>
													</li>
													<li>
														<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">filter_3</span>&nbsp;Sed Ornare</a>
													</li>
												</ul>
											</li>
										</ul>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-sm-6">
							<div class="card">
								<aside class="card-side card-side-img pull-left">
									<img alt="alt text" src="../images/samples/portrait.jpg">
								</aside>
								<div class="card-main">
									<div class="card-inner">
										<p class="card-heading">Primary Area!</p>
										<p class="margin-bottom-lg">
											Lorem ipsum dolor sit amet.<br>
											Consectetur adipiscing elit.
										</p>
									</div>
									<div class="card-action">
										<ul class="nav nav-list margin-no pull-left">
											<li class="dropdown">
												<a class="dropdown-toggle text-black waves-attach" data-toggle="dropdown"><span class="icon">keyboard_arrow_down</span></a>
												<ul class="dropdown-menu dropdown-menu-left">
													<li>
														<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">filter_1</span>&nbsp;Lorem Ipsum</a>
													</li>
													<li>
														<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">filter_2</span>&nbsp;Consectetur Adipiscing</a>
													</li>
													<li>
														<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-left-sm">filter_3</span>&nbsp;Sed Ornare</a>
													</li>
												</ul>
											</li>
										</ul>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</section>
		</div>
	</main>
</asp:Content>

