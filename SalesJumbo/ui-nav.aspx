<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-nav.aspx.cs" Inherits="ui_nav" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Navs</h1>
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
									<p>Navs guide users between different parts of your app.</p>
									<p>Navs available in Material have shared markup, starting with the base <code>.nav</code> class, as well as shared states. Swap modifier classes to switch between each style.</p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Breadcrumb</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<ul class="breadcrumb">
										<li>
											<a href="javascript:void(0)">Material</a>
										</li>
										<li>
											<a href="javascript:void(0)">Extras</a>
										</li>
										<li>
											<a href="javascript:void(0)">Navs</a>
										</li>
										<li class="active">
											<a href="javascript:void(0)">Breadcrumb</a>
										</li>
									</ul>
<pre>
&lt;ul class="breadcrumb"&gt;
    &lt;li&gt;
        &lt;a&gt; ... &lt;/a&gt;
    &lt;/li&gt;
    ...
    &lt;li class="active"&gt;
        &lt;a&gt; ... &lt;/a&gt;
    &lt;/li&gt;
&lt;/ul&gt;
</pre>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Navs</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<ul class="nav">
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
<pre>
&lt;ul class="nav"&gt;
    &lt;li&gt;
        &lt;a&gt; ... &lt;/a&gt;
    &lt;/li&gt;
&lt;/ul&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Horizontal</h3>
									</div>
								</div>
								<div class="card-inner">
									<ul class="nav nav-list">
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
									<p><code>.nav-list</code></p>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Justified</h3>
									</div>
								</div>
								<div class="card-inner">
									<ul class="nav nav-justified">
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
									<p><code>.nav-justified</code></p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Usage</h2>
						<p>The base <code>.nav</code> can be used in conjunction with other material elements, for example <code>.tile</code>, to create more stylish navs.</p>
						<ul class="nav">
							<li>
								<a class="tile waves-attach" href="javascript:void(0)">First Item</a>
							</li>
							<li>
								<a class="tile waves-attach" href="javascript:void(0)">Another Item</a>
							</li>
							<li>
								<a class="tile waves-attach" href="javascript:void(0)">Something Else</a>
							</li>
						</ul>
						<ul class="nav nav-list">
							<li>
								<a class="tile waves-attach" href="javascript:void(0)">First Item</a>
							</li>
							<li>
								<a class="tile waves-attach" href="javascript:void(0)">Another Item</a>
							</li>
							<li>
								<a class="tile waves-attach" href="javascript:void(0)">Something Else</a>
							</li>
						</ul>
						<ul class="nav nav-justified">
							<li>
								<a class="tile waves-attach" href="javascript:void(0)">First Item</a>
							</li>
							<li>
								<a class="tile waves-attach" href="javascript:void(0)">Another Item</a>
							</li>
							<li>
								<a class="tile waves-attach" href="javascript:void(0)">Something Else</a>
							</li>
						</ul>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

