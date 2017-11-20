<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-toolbar.aspx.cs" Inherits="ui_toolbar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Toolbars</h1>
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
									<p>Toolbars are responsive meta components that serve as navigation headers for your application or site. Toolbars appear a step above the sheet of paper affected by their actions.</p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Basic Toolbars</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p>The header keeps its seam with the page, and is pushed off screen.</p>
<pre>
&lt;header class="header"&gt; ... &lt;/header&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Seamed</h3>
									</div>
								</div>
								<div class="card-inner">
									<p>The header is presented as seamed with the page.</p>
<pre>
&lt;header class="header header-seamed"&gt; ... &lt;/header&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Standard</h3>
									</div>
								</div>
								<div class="card-inner">
									<p>The header is a step above the page content.</p>
<pre>
&lt;header class="header header-standard"&gt; ... &lt;/header&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Waterfall</h3>
									</div>
								</div>
								<div class="card-inner">
									<p>Similar to standard header, but header is initially presented as seamed with page, but then separates to form the step.</p>
<pre>
&lt;header class="header header-waterfall"&gt; ... &lt;/header&gt;
</pre>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Coloured Toolbars</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p>Add additional helper classes to apply background colours on toolbars: <code>.header-brand</code>, <code>.header-brand-accent</code>, <code>.header-green</code>, <code>.header-orange</code> &amp; <code>.header-red</code>.</p>
									<p>Alternatively, add <code>.header-transparent</code> to remove background colours from toolbars.</p>
								</div>
							</div>
						</div>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

