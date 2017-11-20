<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-dialog.aspx.cs" Inherits="ui_dialog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Dialogs</h1>
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
									<p>Dialogs contain text and UI controls focused on a specific task. They inform users about critical information, require users to make decisions, or involve multiple tasks.</p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Examples</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p>Toggle dialogs by clicking the links below.</p>
								</div>
								<div class="card-action">
									<div class="card-action-btn pull-right">
										<a class="btn btn-flat btn-brand-accent waves-attach" data-backdrop="static" data-toggle="modal" href="#ui_dialog_example_alert">Alert</a>
										<a class="btn btn-flat btn-brand-accent waves-attach" data-backdrop="static" data-toggle="modal" href="#ui_dialog_example_alert_alt">Alert w/ Title</a>
										<a class="btn btn-flat btn-brand-accent waves-attach" data-toggle="modal" href="#ui_dialog_example_simple">Simple Dialog</a>
									</div>
								</div>
							</div>
						</div>
<pre>
&lt;div aria-hidden="true" class="modal modal-va-middle fade" id="" role="dialog" tabindex="-1"&gt;
    &lt;div class="modal-dialog modal-xs"&gt;
        &lt;div class="modal-content"&gt;
            &lt;div class="modal-heading"&gt; ... &lt;/div&gt;
            &lt;div class="modal-inner"&gt; ... &lt;/div&gt;
            &lt;div class="modal-footer"&gt; ... &lt;/div&gt;
        &lt;/div&gt;
    &lt;/div&gt;
&lt;/div&gt;
</pre>
						<div class="media margin-bottom margin-top">
							<div class="media-object margin-left-sm pull-right">
								<span class="icon icon-lg text-brand-accent">info_outline</span>
							</div>
							<div class="media-inner">
								<span>Dialogs are a sub-type of modals, and the examples covered here are for standard material system dialogs. Other modal constructions are covered in <a href="ui-modal.html">the modal page</a>.</span>
							</div>
						</div>
					</section>
				</div>
			</div>
		</div>
	</main>

    <div aria-hidden="true" class="modal modal-va-middle fade" id="ui_dialog_example_alert" role="dialog" tabindex="-1">
		<div class="modal-dialog modal-xs">
			<div class="modal-content">
				<div class="modal-inner">
					<p class="h5 margin-top-sm text-black-hint">Discard draft?</p>
				</div>
				<div class="modal-footer">
					<p class="text-left"><a class="btn btn-flat btn-brand-accent waves-attach" data-dismiss="modal">Cancel</a><a class="btn btn-flat btn-brand-accent waves-attach" data-dismiss="modal">Discard</a></p>
				</div>
			</div>
		</div>
	</div>

    <div aria-hidden="true" class="modal modal-va-middle fade" id="ui_dialog_example_alert_alt" role="dialog" tabindex="-1">
		<div class="modal-dialog modal-xs">
			<div class="modal-content">
				<div class="modal-heading">
					<p class="modal-title">Use location service?</p>
				</div>
				<div class="modal-inner">
					<p class="h5 margin-top-sm text-black-hint">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
				</div>
				<div class="modal-footer">
					<p class="text-left"><a class="btn btn-flat btn-brand-accent waves-attach" data-dismiss="modal">Disagree</a><a class="btn btn-flat btn-brand-accent waves-attach" data-dismiss="modal">Agree</a></p>
				</div>
			</div>
		</div>
	</div>

    <div aria-hidden="true" class="modal modal-va-middle fade" id="ui_dialog_example_simple" role="dialog" tabindex="-1">
		<div class="modal-dialog modal-xs">
			<div class="modal-content">
				<div class="modal-heading">
					<h2 class="modal-title">Set backup account</h2>
				</div>
				<ul class="nav">
					<li>
						<a class="margin-bottom-sm waves-attach" data-dismiss="modal" href="javascript:void(0)">
							<div class="avatar avatar-inline margin-left-sm margin-right-sm">
								<img alt="alt text for username avatar" src="../images/users/avatar-001.jpg">
							</div>
							<span class="margin-right-sm text-black">username</span>
						</a>
					</li>
					<li>
						<a class="margin-bottom-sm waves-attach" data-dismiss="modal" href="javascript:void(0)">
							<div class="avatar avatar-inline margin-left-sm margin-right-sm">
								<img alt="alt text for another_account avatar" src="../images/users/avatar-001.jpg">
							</div>
							<span class="margin-right-sm text-black">another_account</span>
						</a>
					</li>
					<li>
						<a class="margin-bottom-sm waves-attach" data-dismiss="modal" href="javascript:void(0)">
							<div class="avatar avatar-inline margin-left-sm margin-right-sm">
								<span class="icon icon-lg text-black">add</span>
							</div>
							<span class="margin-right-sm text-black">add account</span>
						</a>
					</li>
				</ul>
			</div>
		</div>
	</div>

</asp:Content>

