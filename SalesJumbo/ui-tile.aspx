<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-tile.aspx.cs" Inherits="ui_tile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Tiles</h1>
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
									<p>Tiles present collections of related content in a consistent format, using hierarchy to enhance readability by prioritizing a consistent type or set of content.</p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Basic Tiles</h2>
						<div class="tile-wrap">
							<div class="tile">
								<div class="tile-side margin-right">
									<div class="avatar avatar-sm">
										<span class="icon">alarm</span>
									</div>
								</div>
								<div class="tile-inner">
									<span>lorem ipsum dolor sit amet</span>
								</div>
							</div>
							<div class="tile">
								<div class="tile-side margin-right">
									<div class="avatar avatar-sm avatar-brand">
										<span class="icon">backup</span>
									</div>
								</div>
								<div class="tile-action tile-action-show">
									<ul class="nav nav-list margin-no pull-right">
										<li>
											<a class="text-black-sec waves-attach" href="javascript:void(0)"><span class="icon">delete</span></a>
										</li>
									</ul>
								</div>
								<div class="tile-inner">
									<span class="text-overflow">consectetur adipiscing elit, consectetur adipiscing elit, consectetur adipiscing elit</span>
								</div>
							</div>
							<div class="tile">
								<div class="tile-side margin-right">
									<div class="avatar avatar-sm avatar-brand-accent">
										<span class="icon">launch</span>
									</div>
								</div>
								<div class="tile-action">
									<ul class="nav nav-list margin-no pull-right">
										<li>
											<a class="text-black-sec waves-attach" href="javascript:void(0)"><span class="icon">add</span></a>
										</li>
										<li>
											<a class="text-black-sec waves-attach" href="javascript:void(0)"><span class="icon">flag</span></a>
										</li>
										<li class="dropdown">
											<a class="dropdown-toggle text-black-sec waves-attach" data-toggle="dropdown"><span class="icon">settings</span></a>
											<ul class="dropdown-menu dropdown-menu-right">
												<li>
													<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-right-sm">loop</span>Lorem Ipsum</a>
												</li>
												<li>
													<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-right-sm">replay</span>Consectetur Adipiscing</a>
												</li>
												<li>
													<a class="waves-attach" href="javascript:void(0)"><span class="icon margin-right-sm">shuffle</span>Sed Ornare</a>
												</li>
											</ul>
										</li>
									</ul>
								</div>
								<div class="tile-inner">
									<span class="text-overflow">sed ornare orci lorem</span>
								</div>
							</div>
						</div>
<pre>
&lt;div class="tile-wrap"&gt;
    &lt;div class="tile"&gt;
        &lt;div class="tile-side margin-right"&gt; ... &lt;/div&gt;
        &lt;div class="tile-action"&gt; ... &lt;/div&gt;
        &lt;div class="tile-inner"&gt; ... &lt;/div&gt;
    &lt;/div&gt;
    ...
&lt;/div&gt;
</pre>
						<h2 class="content-sub-heading">Collapsible Tiles</h2>
						<div class="tile-wrap">
							<div class="tile tile-collapse">
								<div data-target="#ui_tile_example_1" data-toggle="tile">
									<div class="tile-side margin-right" data-ignore="tile">
										<div class="avatar avatar-sm">
											<span class="icon">alarm</span>
										</div>
									</div>
									<div class="tile-inner">
										<div class="text-overflow">lorem ipsum dolor sit amet</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_1">
									<div class="tile-sub">
										<p>Additional information<br><small>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam.</small></p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_1"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
							<div class="tile tile-collapse">
								<div data-target="#ui_tile_example_2" data-toggle="tile">
									<div class="tile-side margin-right">
										<div class="avatar avatar-sm avatar-brand">
											<span class="icon">backup</span>
										</div>
									</div>
									<div class="tile-inner">
										<div class="text-overflow">consectetur adipiscing elit</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_2">
									<div class="tile-sub">
										<p>Additional information<br><small>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam.</small></p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_2"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
							<div class="tile tile-collapse">
								<div data-target="#ui_tile_example_3" data-toggle="tile">
									<div class="tile-side margin-right">
										<div class="avatar avatar-sm avatar-brand-accent">
											<span class="icon">launch</span>
										</div>
									</div>
									<div class="tile-inner">
										<div class="text-overflow">sed ornare orci lorem</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_3">
									<div class="tile-sub">
										<p>Additional information<br><small>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam.</small></p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_3"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
						</div>
<pre>
&lt;div class="tile-wrap"&gt;
    &lt;div class="tile tile-collapse"&gt;
        &lt;div data-target="..." data-toggle="tile"&gt;
            &lt;div class="tile-inner"&gt; ... &lt;/div&gt;
        &lt;/div&gt;
        &lt;div class="tile-active-show collapse" id="..."&gt;
            &lt;div class="tile-sub"&gt; ... &lt;/div&gt;
            &lt;div class="tile-footer"&gt; ... &lt;/div&gt;
        &lt;/div&gt;
    &lt;/div&gt;
&lt;/div&gt;
</pre>
						<div class="tile-wrap" id="ui_tile_example_parent">
							<div class="tile">
								<div class="tile-inner">
									<code>data-parent=""</code> extends the default collapse behaviour to create an accordion.
								</div>
							</div>
							<div class="tile tile-collapse">
								<div data-parent="#ui_tile_example_parent" data-target="#ui_tile_example_4" data-toggle="tile">
									<div class="tile-side margin-right">
										<div class="avatar avatar-sm">
											<span class="icon">alarm</span>
										</div>
									</div>
									<div class="tile-inner">
										<div class="text-overflow">lorem ipsum dolor sit amet</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_4">
									<div class="tile-sub">
										<p>Additional information<br><small>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam.</small></p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_4"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
							<div class="tile tile-collapse">
								<div data-parent="#ui_tile_example_parent" data-target="#ui_tile_example_5" data-toggle="tile">
									<div class="tile-side margin-right">
										<div class="avatar avatar-sm avatar-brand">
											<span class="icon">backup</span>
										</div>
									</div>
									<div class="tile-inner">
										<div class="text-overflow">consectetur adipiscing elit</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_5">
									<div class="tile-sub">
										<p>Additional information<br><small>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam.</small></p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_5"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
							<div class="tile tile-collapse">
								<div data-parent="#ui_tile_example_parent" data-target="#ui_tile_example_6" data-toggle="tile">
									<div class="tile-side margin-right">
										<div class="avatar avatar-sm avatar-brand-accent">
											<span class="icon">launch</span>
										</div>
									</div>
									<div class="tile-inner">
										<div class="text-overflow">sed ornare orci lorem</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_6">
									<div class="tile-sub">
										<p>Additional information<br><small>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam.</small></p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_6"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="tile-wrap">
							<div class="tile">
								<div class="tile-inner">
									expands the tile even wider when space is available. <code>.tile-collapse-full</code>
								</div>
							</div>
							<div class="tile tile-collapse tile-collapse-full">
								<div data-parent=".content" data-target="#ui_tile_example_7" data-toggle="tile">
									<div class="tile-side pull-left">
										<div class="avatar avatar-sm">
											<span class="icon">alarm</span>
										</div>
									</div>
									<div class="tile-inner">
										<div class="text-overflow">lorem ipsum dolor sit amet</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_7">
									<div class="tile-sub">
										<p>Additional information<br><small>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam.</small></p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_7"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
							<div class="tile tile-collapse tile-collapse-full">
								<div data-parent=".content" data-target="#ui_tile_example_8" data-toggle="tile">
									<div class="tile-side pull-left">
										<div class="avatar avatar-sm avatar-brand">
											<span class="icon">backup</span>
										</div>
									</div>
									<div class="tile-inner">
										<div class="text-overflow">consectetur adipiscing elit</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_8">
									<div class="tile-sub">
										<p>Additional information<br><small>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam.</small></p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_8"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
							<div class="tile tile-collapse tile-collapse-full">
								<div data-parent=".content" data-target="#ui_tile_example_9" data-toggle="tile">
									<div class="tile-side pull-left">
										<div class="avatar avatar-sm avatar-brand-accent">
											<span class="icon">launch</span>
										</div>
									</div>
									<div class="tile-inner">
										<div class="text-overflow">sed ornare orci lorem</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_9">
									<div class="tile-sub">
										<p>Additional information<br><small>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam.</small></p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_9"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Coloured Tiles</h2>
						<div class="tile-wrap">
							<div class="tile tile-collapse tile-brand">
								<div data-target="#ui_tile_example_brand" data-toggle="tile">
									<div class="tile-inner">
										<div class="text-overflow">Brand tile</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_brand">
									<div class="tile-sub">
										<p>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam. This is a <a href="javascript:void(0)">link</a> among some other text.</p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_brand"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="tile-wrap">
							<div class="tile tile-collapse tile-brand-accent">
								<div data-target="#ui_tile_example_brand_accent" data-toggle="tile">
									<div class="tile-inner">
										<div class="text-overflow">Brand accent tile</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_brand_accent">
									<div class="tile-sub">
										<p>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam. This is a <a href="javascript:void(0)">link</a> among some other text.</p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_brand_accent"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="tile-wrap">
							<div class="tile tile-collapse tile-green">
								<div data-target="#ui_tile_example_green" data-toggle="tile">
									<div class="tile-inner">
										<div class="text-overflow">Green tile</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_green">
									<div class="tile-sub">
										<p>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam. This is a <a href="javascript:void(0)">link</a> among some other text.</p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_green"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="tile-wrap">
							<div class="tile tile-collapse tile-orange">
								<div data-target="#ui_tile_example_orange" data-toggle="tile">
									<div class="tile-inner">
										<div class="text-overflow">Orange tile</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_orange">
									<div class="tile-sub">
										<p>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam. This is a <a href="javascript:void(0)">link</a> among some other text.</p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-right">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_orange"><span class="icon">close</span>&nbsp;Cancel</a>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="tile-wrap">
							<div class="tile tile-collapse tile-red">
								<div data-target="#ui_tile_example_red" data-toggle="tile">
									<div class="tile-inner">
										<div class="text-overflow">Red tile</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_tile_example_red">
									<div class="tile-sub">
										<p>Aliquam in pharetra leo. In congue, massa sed elementum dictum, justo quam efficitur risus, in posuere mi orci ultrices diam. This is a <a href="javascript:void(0)">link</a> among some other text.</p>
									</div>
									<div class="tile-footer">
										<div class="tile-footer-btn pull-rightx">
											<a class="btn btn-flat waves-attach" href="javascript:void(0)"><span class="icon">check</span>&nbsp;OK</a>
											<a class="btn btn-flat waves-attach" data-toggle="tile" href="#ui_tile_example_red"><span class="icon">close</span>&nbsp;Cancel</a>
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

