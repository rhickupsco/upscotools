<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-affix.aspx.cs" Inherits="ui_affix" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Affix</h1>
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
									<p>The affix plugin toggles <code>position: fixed;</code> on and off, emulating the effect found with <code>position: sticky;</code>.</p>
									<p>Material uses Bootstrap's affix, please visit Bootstrap's documentation site for detailed usage.</p>
								</div>
								<div class="card-action">
									<div class="card-action-btn pull-right">
										<a class="btn btn-flat waves-attach" href="http://getbootstrap.com/javascript/#affix" target="_blank">Bootstrap Affix<span class="icon margin-right-sm">open_in_new</span></a>
									</div>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Example</h2>
						<p><code>.header-waterfall</code> on the top of this documentation site is a live demo of the affix plugin.</p>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p class="text-black-hint text-center" style="height: 1000px;">Placeholder</p>
								</div>
							</div>
						</div>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

