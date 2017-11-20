<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-snackbar.aspx.cs" Inherits="ui_snackbar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Snackbars</h1>
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
									<p>Snackbars provide lightweight feedback about an operation by showing a brief message at the bottom of the screen. Snackbars can contain an action.</p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Examples</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p>Toggle snackbars by clicking the links below.</p>
								</div>
								<div class="card-action">
									<div class="card-action-btn pull-left">
										<a class="btn btn-flat btn-brand-accent waves-attach" id="ui_snackbar_toggle_1">Snackbar</a>
										<a class="btn btn-flat btn-brand-accent waves-attach" id="ui_snackbar_toggle_2">Snackbar with Action</a>
									</div>
								</div>
							</div>
						</div>
<pre>
.snackbar({
    alive: 6000,
    content: ...,
    hide: ...,
    show: ...
});
</pre>
						<h2 class="content-sub-heading">Options</h2>
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
										<td class="text-nowrap">alive</td>
										<td>Time in milliseconds snackbar will be displayed without user interaction. Default is 6000.</td>
									</tr>
									<tr>
										<td class="text-nowrap">content</td>
										<td>Snackbar message.</td>
									</tr>
									<tr>
										<td class="text-nowrap">hide <small class="text-black-sec">(optional)</small></td>
										<td>Fires after the <code>hide</code> method is called by the snackbar.</td>
									</tr>
									<tr>
										<td class="text-nowrap">show <small class="text-black-sec">(optional)</small></td>
										<td>Fires after the <code>show</code> method is called by the snackbar.</td>
									</tr>
								</tbody>
							</table>
						</div>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

