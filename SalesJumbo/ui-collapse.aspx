<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-collapse.aspx.cs" Inherits="ui_collapse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Collapse</h1>
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
									<p>Collapse is a flexible plugin that utilises a handful of classes for easy toggle behavior.</p>
									<p>Material uses Bootstrap's collapse, please visit Bootstrap's documentation site for detailed usage.</p>
								</div>
								<div class="card-action">
									<div class="card-action-btn pull-right">
										<a class="btn btn-flat waves-attach" href="http://getbootstrap.com/javascript/#collapse" target="_blank">Bootstrap Collapse<span class="icon margin-right-sm">open_in_new</span></a>
									</div>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Example</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p>
										<a class="btn btn-flat collapsed waves-attach" data-toggle="collapse" href="#ui_collapse_example">
											<span class="collapsed-hide">Collapse</span>
											<span class="collapsed-show">Expand</span>
										</a>
									</p>
									<div class="collapsible-region collapse" id="ui_collapse_example">
										<p>Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.</p>
										<p>Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor.</p>
										<p>Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.</p>
									</div>
								</div>
							</div>
						</div>
<pre>
&lt;a data-toggle="collapse" href="#selector"&gt; ... &lt;/a&gt;
&lt;div class="collapse collapsible-region" id="selector"&gt; ... &lt;/div&gt;
</pre>
						<h2 class="content-sub-heading">Helper Classes</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner margin-bottom-no">
									<p>Helper classes <code>.collapsed-hide</code> and <code>.collapsed-show</code> can be used to change content of collapse's toggle depending on whether its target is collapsed or expanded.</p>
									<div class="card-table">
										<div class="table-responsive">
											<table class="table" title="A table within a card">
												<thead>
													<tr>
														<th>Class</th>
														<th>Collapsed</th>
														<th>Expanded</th>
													</tr>
												</thead>
												<tbody>
													<tr>
														<td><code>.collapsed-hide</code></td>
														<td>Hidden</td>
														<td>Shown</td>
													</tr>
													<tr>
														<td><code>.collapsed-show</code></td>
														<td>Shown</td>
														<td>Hidden</td>
													</tr>
												</tbody>
											</table>
										</div>
									</div>
								</div>
							</div>
						</div>
<pre>
&lt;a data-toggle="collapse" href="#selector"&gt;
    ...
    &lt;span class="collapsed-hide"&gt; show when expanded &lt;/span&gt;
    &lt;span class="collapsed-hide"&gt; show when collapsed &lt;/span&gt;
&lt;/a&gt;
</pre>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

