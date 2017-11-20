<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-avatar.aspx.cs" Inherits="ui_avatar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Avatars</h1>
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
									<span class="avatar"><img alt="alt text for John Smith avatar" src="../images/users/avatar-001.jpg"></span>
<pre>
&lt;span class="avatar"&gt;&lt;img alt="..." src="..."&gt;&lt;/span&gt;
</pre>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Colours</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p><span class="avatar avatar-inline avatar-brand margin-left">1</span><code>.avatar-brand</code></p>
									<p><span class="avatar avatar-inline avatar-brand-accent margin-left">2</span><code>.avatar-brand-accent</code></p>
									<p><span class="avatar avatar-inline avatar-green margin-left">G</span><code>.avatar-green</code></p>
									<p><span class="avatar avatar-inline avatar-orange margin-left">O</span><code>.avatar-orange</code></p>
									<p><span class="avatar avatar-inline avatar-red margin-left">R</span><code>.avatar-red</code></p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Sizes</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<div class="row">
										<div class="col-xs-4">
											<p class="text-center"><span class="avatar avatar-inline avatar-lg">L</span></p>
											<p class="text-center"><code>.avatar-lg</code></p>
										</div>
										<div class="col-xs-4">
											<p class="text-center"><span class="avatar avatar-inline avatar-sm">S</span></p>
											<p class="text-center"><code>.avatar-sm</code></p>
										</div>
										<div class="col-xs-4">
											<p class="text-center"><span class="avatar avatar-inline avatar-xs">X</span></p>
											<p class="text-center"><code>.avatar-xs</code></p>
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

