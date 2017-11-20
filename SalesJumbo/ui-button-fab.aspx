<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-button-fab.aspx.cs" Inherits="ui_button_fab" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Buttons: Floating Action Buttons</h1>
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
									<p>Floating action buttons are used for a promoted action. They are distinguished by a circled icon floating above the UI and have motion behaviours that include morphing, launching, and a transferring anchor point.</p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Basic FAB</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p class="margin-top-no"><a class="fbtn waves-attach waves-circle">ب</a></p>
<pre>
&lt;a class="fbtn waves-attach waves-circle"&gt; ... &lt;/a&gt;
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
									<div class="row">
										<div class="col-xx-6">
											<p class="margin-top-no"><a class="fbtn fbtn-brand waves-attach waves-circle waves-light">آ</a></p>
										</div>
										<div class="col-xx-6">
											<p class="margin-top-no"><a class="fbtn fbtn-brand-accent waves-attach waves-circle waves-light">ب</a></p>
										</div>
									</div>
<pre>
&lt;a class="fbtn fbtn-brand waves-attach waves-circle waves-light"&gt; ... &lt;/a&gt;

&lt;a class="fbtn fbtn-brand-accent waves-attach waves-circle waves-light"&gt; ... &lt;/a&gt;
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
									<div class="row">
										<div class="col-xx-4">
											<p class="margin-top-no"><a class="fbtn fbtn-green waves-attach waves-circle">آ</a></p>
											<p class="margin-top-no text-center"><code>.fbtn-green</code></p>
										</div>
										<div class="col-xx-4">
											<p class="margin-top-no"><a class="fbtn fbtn-orange waves-attach waves-circle">ب</a></p>
											<p class="margin-top-no text-center"><code>.fbtn-orange</code></p>
										</div>
										<div class="col-xx-4">
											<p class="margin-top-no"><a class="fbtn fbtn-red waves-attach waves-circle waves-light">ث</a></p>
											<p class="margin-top-no text-center"><code>.fbtn-red</code></p>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Positioning</h3>
									</div>
								</div>
								<div class="card-inner">
									<p>Use <code>.fbtn-container</code> to place FAB at the bottom right corner of a page. Creating a customised wrapper may be required to place FAB somewhere else on a page.</p>
<pre>
&lt;div class="fbtn-container"&gt;
    &lt;a class="fbtn"&gt; ... &lt;/a&gt;
&lt;/div&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Sizes</h3>
									</div>
								</div>
								<div class="card-inner">
									<p class="margin-top-no"><a class="fbtn fbtn-lg waves-attach waves-circle"><span class="icon">add</span></a></p>
<pre>
&lt;a class="fbtn fbtn-lg"&gt; ... &lt;/a&gt;
</pre>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Dropdown/Dropup</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Dropdown</h3>
									</div>
								</div>
								<div class="card-inner">
									<div class="fbtn-inner">
										<a class="fbtn fbtn-lg waves-attach waves-circle" data-toggle="dropdown"><span class="icon">add</span></a>
										<div class="fbtn-dropdown">
											<a class="fbtn waves-attach waves-circle" href="javascript:void(0)"><span class="icon">more_horiz</span></a>
											<a class="fbtn waves-attach waves-circle" href="javascript:void(0)"><span class="icon">more_horiz</span></a>
											<a class="fbtn waves-attach waves-circle" href="javascript:void(0)"><span class="icon">more_horiz</span></a>
										</div>
									</div>
<pre>
&lt;div class="fbtn-inner"&gt;
    &lt;a class="fbtn fbtn-lg" data-toggle="dropdown"&gt; ... &lt;/a&gt;
    &lt;div class="fbtn-dropdown"&gt;
        &lt;a class="fbtn fbtn-lg"&gt; ... &lt;/a&gt;
        ...
    &lt;/div&gt;
&lt;/div&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Dropup</h3>
									</div>
								</div>
								<div class="card-inner">
									<div class="fbtn-inner">
										<a class="fbtn fbtn-lg waves-attach waves-circle" data-toggle="dropdown"><span class="icon">add</span></a>
										<div class="fbtn-dropup">
											<a class="fbtn waves-attach waves-circle" href="javascript:void(0)"><span class="icon">more_horiz</span></a>
											<a class="fbtn waves-attach waves-circle" href="javascript:void(0)"><span class="icon">more_horiz</span></a>
											<a class="fbtn waves-attach waves-circle" href="javascript:void(0)"><span class="icon">more_horiz</span></a>
										</div>
									</div>
<pre>
&lt;div class="fbtn-inner"&gt;
    &lt;a class="fbtn fbtn-lg" data-toggle="dropdown"&gt; ... &lt;/a&gt;
    &lt;div class="fbtn-dropup"&gt;
        &lt;a class="fbtn fbtn-lg"&gt; ... &lt;/a&gt;
        ...
    &lt;/div&gt;
&lt;/div&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Transition Animation</h3>
									</div>
								</div>
								<div class="card-inner">
									<p>Add meaningful animation to FAB by combining <code>.fbtn-ori</code> and <code>.fbtn-sub</code>. <code>.fbtn-ori</code> displays by default and translates to <code>.fbtn-sub</code> once the dropdown/dropup menu associated with its FAB is being made visible to the user. <code>.fbtn-sub</code> then translates back to the original <code>.fbtn-ori</code> once the associated menu starts to hide from the user.</p>
									<div class="fbtn-inner">
										<a class="fbtn fbtn-lg waves-attach waves-circle" data-toggle="dropdown"><span class="fbtn-ori icon">add</span><span class="fbtn-sub icon">close</span></a>
										<div class="fbtn-dropdown">
											<a class="fbtn waves-attach waves-circle" href="javascript:void(0)"><span class="icon">more_horiz</span></a>
											<a class="fbtn waves-attach waves-circle" href="javascript:void(0)"><span class="icon">more_horiz</span></a>
											<a class="fbtn waves-attach waves-circle" href="javascript:void(0)"><span class="icon">more_horiz</span></a>
										</div>
									</div>
<pre>
&lt;div class="fbtn-inner"&gt;
    &lt;a class="fbtn fbtn-lg" data-toggle="dropdown"&gt;
        &lt;span class="fbtn-ori"&gt; ... &lt;/span&gt;
        &lt;span class="fbtn-sub"&gt; ... &lt;/span&gt;
    &lt;/a&gt;
    &lt;div class="fbtn-dropdown"&gt;
        ...
    &lt;/div&gt;
&lt;/div&gt;
</pre>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Tooltip Text</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<div class="row">
										<div class="col-xx-6">
											<a class="fbtn waves-attach waves-circle"><span class="fbtn-text">Tooltip Text (Right)</span><span class="icon">add</span></a>
										</div>
										<div class="col-xx-6">
											<a class="fbtn waves-attach waves-circle"><span class="fbtn-text fbtn-text-left">Tooltip Text (Left)</span><span class="icon">add</span></a>
										</div>
									</div>
<pre>
&lt;a class="fbtn"&gt;
    &lt;span class="fbtn-text"&gt; ... &lt;/span&gt;
    ...
&lt;/a&gt;

&lt;a class="fbtn"&gt;
    &lt;span class="fbtn-text fbtn-text-left"&gt; ... &lt;/span&gt;
    ...
&lt;/a&gt;
</pre>
								</div>
							</div>
						</div>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

