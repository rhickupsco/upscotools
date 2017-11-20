<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-button.aspx.cs" Inherits="ui_button" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Buttons</h1>
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
									<p>A button clearly communicates what action will occur when the user touches it. It consists of text, an image, or both, designed in accordance with your app’s colour theme.</p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Flat Buttons</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p class="margin-top-no"><a class="btn btn-flat">Button</a>&nbsp;&nbsp;&nbsp;<a class="btn btn-flat waves-attach">Ripple</a></p>
<pre>
&lt;a class="btn btn-flat"&gt; ... &lt;/a&gt;

&lt;a class="btn btn-flat waves-attach"&gt; ... &lt;/a&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Brand Colours</h3>
									</div>
								</div>
								<div class="card-inner">
									<p class="margin-top-no"><a class="btn btn-flat btn-brand">Button</a>&nbsp;&nbsp;&nbsp;<a class="btn btn-flat btn-brand waves-attach">Ripple</a></p>
									<p class="margin-top-no"><a class="btn btn-flat btn-brand-accent">Button</a>&nbsp;&nbsp;&nbsp;<a class="btn btn-flat btn-brand-accent waves-attach">Ripple</a></p>
<pre>
&lt;a class="btn btn-flat btn-brand"&gt; ... &lt;/a&gt;

&lt;a class="btn btn-flat btn-brand waves-attach"&gt; ... &lt;/a&gt;

&lt;a class="btn btn-flat btn-brand-accent"&gt; ... &lt;/a&gt;

&lt;a class="btn btn-flat btn-brand-accent waves-attach"&gt; ... &lt;/a&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Colour Palettes</h3>
									</div>
								</div>
								<div class="card-inner">
									<p class="margin-top-no"><a class="btn btn-flat btn-green waves-attach">.btn-green</a>&nbsp;&nbsp;&nbsp;<a class="btn btn-flat btn-orange waves-attach">.btn-orange</a>&nbsp;&nbsp;&nbsp;<a class="btn btn-flat btn-red waves-attach">.btn-red</a></p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Raised Buttons</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p class="margin-top-no"><a class="btn">Button</a>&nbsp;&nbsp;&nbsp;<a class="btn waves-attach">Ripple</a></p>
<pre>
&lt;a class="btn"&gt; ... &lt;/a&gt;

&lt;a class="btn waves-attach&gt; ... &lt;/a&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Brand Colours</h3>
									</div>
								</div>
								<div class="card-inner">
									<p class="margin-top-no"><a class="btn btn-brand">Button</a>&nbsp;&nbsp;&nbsp;<a class="btn btn-brand waves-attach waves-light">Ripple</a></p>
									<p class="margin-top-no"><a class="btn btn-brand-accent">Button</a>&nbsp;&nbsp;&nbsp;<a class="btn btn-brand-accent waves-attach waves-light">Ripple</a></p>
<pre>
&lt;a class="btn btn-brand"&gt; ... &lt;/a&gt;

&lt;a class="btn btn-brand waves-attach waves-light"&gt; ... &lt;/a&gt;

&lt;a class="btn btn-brand-accent"&gt; ... &lt;/a&gt;

&lt;a class="btn btn-brand-accent waves-attach waves-light"&gt; ... &lt;/a&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Colour Palettes</h3>
									</div>
								</div>
								<div class="card-inner">
									<p class="margin-top-no"><a class="btn btn-green waves-attach">.btn-green</a>&nbsp;&nbsp;&nbsp;<a class="btn btn-orange waves-attach">.btn-orange</a>&nbsp;&nbsp;&nbsp;<a class="btn btn-red waves-attach waves-light">.btn-red</a></p>
								</div>
							</div>
						</div>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

