<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-progress.aspx.cs" Inherits="ui_progress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Progress</h1>
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
									<p>Minimise visual changes that occur while your app loads content by representing each operation with a single activity indicator.</p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Circular</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<div class="text-center">
										<div class="progress-circular progress-circular-inline">
											<div class="progress-circular-wrapper">
												<div class="progress-circular-inner">
													<div class="progress-circular-left">
														<div class="progress-circular-spinner"></div>
													</div>
													<div class="progress-circular-gap"></div>
													<div class="progress-circular-right">
														<div class="progress-circular-spinner"></div>
													</div>
												</div>
											</div>
										</div>
									</div>
<pre>
&lt;div class="progress-circular"&gt;
    &lt;div class="progress-circular-wrapper"&gt;
        &lt;div class="progress-circular-inner"&gt;
            &lt;div class="progress-circular-left"&gt;
                &lt;div class="progress-circular-spinner"&gt;&lt;/div&gt;
            &lt;/div&gt;
            &lt;div class="progress-circular-gap"&gt;&lt;/div&gt;
            &lt;div class="progress-circular-right"&gt;
                &lt;div class="progress-circular-spinner"&gt;&lt;/div&gt;
            &lt;/div&gt;
        &lt;/div&gt;
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
										<h3 class="h5 margin-bottom-no margin-top-no">Coloured Circular</h3>
									</div>
								</div>
								<div class="card-inner">
									<div class="row">
										<div class="col-xs-3 col-xx-6">
											<div class="text-center">
												<div class="progress-circular progress-circular-inline progress-circular-brand">
													<div class="progress-circular-wrapper">
														<div class="progress-circular-inner">
															<div class="progress-circular-left">
																<div class="progress-circular-spinner"></div>
															</div>
															<div class="progress-circular-gap"></div>
															<div class="progress-circular-right">
																<div class="progress-circular-spinner"></div>
															</div>
														</div>
													</div>
												</div>
												<p><code>.progress-circular-brand</code></p>
											</div>
										</div>
										<div class="col-xs-3 col-xx-6">
											<div class="text-center">
												<div class="progress-circular progress-circular-inline progress-circular-green">
													<div class="progress-circular-wrapper">
														<div class="progress-circular-inner">
															<div class="progress-circular-left">
																<div class="progress-circular-spinner"></div>
															</div>
															<div class="progress-circular-gap"></div>
															<div class="progress-circular-right">
																<div class="progress-circular-spinner"></div>
															</div>
														</div>
													</div>
												</div>
												<p><code>.progress-circular-green</code></p>
											</div>
										</div>
										<div class="col-xs-3 col-xx-6">
											<div class="text-center">
												<div class="progress-circular progress-circular-inline progress-circular-orange">
													<div class="progress-circular-wrapper">
														<div class="progress-circular-inner">
															<div class="progress-circular-left">
																<div class="progress-circular-spinner"></div>
															</div>
															<div class="progress-circular-gap"></div>
															<div class="progress-circular-right">
																<div class="progress-circular-spinner"></div>
															</div>
														</div>
													</div>
												</div>
												<p><code>.progress-circular-orange</code></p>
											</div>
										</div>
										<div class="col-xs-3 col-xx-6">
											<div class="text-center">
												<div class="progress-circular progress-circular-inline progress-circular-red">
													<div class="progress-circular-wrapper">
														<div class="progress-circular-inner">
															<div class="progress-circular-left">
																<div class="progress-circular-spinner"></div>
															</div>
															<div class="progress-circular-gap"></div>
															<div class="progress-circular-right">
																<div class="progress-circular-spinner"></div>
															</div>
														</div>
													</div>
												</div>
												<p><code>.progress-circular-red</code></p>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Determinate Linear</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<div class="progress">
										<div class="progress-bar" style="width: 30%"></div>
									</div>
<pre>
&lt;div class="progress"&gt;
    &lt;div class="progress-bar"&gt;&lt;/div&gt;
&lt;/div&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Coloured Determinate Linear</h3>
									</div>
								</div>
								<div class="card-inner">
									<div class="progress progress-brand">
										<div class="progress-bar" style="width: 40%"></div>
									</div>
									<p><code>.progress-brand</code></p>
									<div class="progress progress-green">
										<div class="progress-bar" style="width: 50%"></div>
									</div>
									<p><code>.progress-green</code></p>
									<div class="progress progress-orange">
										<div class="progress-bar" style="width: 60%"></div>
									</div>
									<p><code>.progress-orange</code></p>
									<div class="progress progress-red">
										<div class="progress-bar" style="width: 70%"></div>
									</div>
									<p><code>.progress-red</code></p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Indeterminate Linear</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<div class="progress">
										<div class="progress-bar-indeterminate"></div>
									</div>
<pre>
&lt;div class="progress"&gt;
    &lt;div class="progress-bar-indeterminate"&gt;&lt;/div&gt;
&lt;/div&gt;
</pre>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Load Bars</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<div class="progress">
										<div class="load-bar">
											<div class="load-bar-base">
												<div class="load-bar-content">
													<div class="load-bar-progress"></div>
													<div class="load-bar-progress load-bar-progress-brand"></div>
													<div class="load-bar-progress load-bar-progress-green"></div>
													<div class="load-bar-progress load-bar-progress-orange"></div>
												</div>
											</div>
										</div>
										<div class="load-bar">
											<div class="load-bar-base">
												<div class="load-bar-content">
													<div class="load-bar-progress"></div>
													<div class="load-bar-progress load-bar-progress-orange"></div>
													<div class="load-bar-progress load-bar-progress-green"></div>
													<div class="load-bar-progress load-bar-progress-brand"></div>
												</div>
											</div>
										</div>
									</div>
									<p><span class="label label-brand-accent">Usage</span></p>
									<p>A <code>.load-bar</code> requires four different colours to achieve the best visual effect. A complete load bar consists of two separate <code>.load-bar</code>s, and the order of <code>.load-bar-progress</code>s in each of the two <code>.load-bar</code>s is different.</p>
<pre>
&lt;div class="progress"&gt;
    &lt;div class="load-bar"&gt;
        &lt;div class="load-bar-base"&gt;
            &lt;div class="load-bar-content"&gt;
                &lt;div class="load-bar-progress"&gt;&lt;/div&gt;
                &lt;div class="load-bar-progress load-bar-progress-brand"&gt;&lt;/div&gt;
                &lt;div class="load-bar-progress load-bar-progress-green"&gt;&lt;/div&gt;
                &lt;div class="load-bar-progress load-bar-progress-orange"&gt;&lt;/div&gt;
            &lt;/div&gt;
        &lt;/div&gt;
    &lt;/div&gt;
    &lt;div class="load-bar"&gt;
        &lt;div class="load-bar-base"&gt;
            &lt;div class="load-bar-content"&gt;
                &lt;div class="load-bar-progress"&gt;&lt;/div&gt;
                &lt;div class="load-bar-progress load-bar-progress-orange"&gt;&lt;/div&gt;
                &lt;div class="load-bar-progress load-bar-progress-green"&gt;&lt;/div&gt;
                &lt;div class="load-bar-progress load-bar-progress-brand"&gt;&lt;/div&gt;
            &lt;/div&gt;
        &lt;/div&gt;
    &lt;/div&gt;
&lt;/div&gt;
</pre>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Loading Examples</h2>
						<div class="media margin-bottom margin-top">
							<div class="media-object pull-left">
								<span class="icon icon-lg text-brand-accent">info_outline</span>
							</div>
							<div class="media-inner">
								<span>Use <code>.el-loading</code> with progress to indicate additional content is being loaded. Add <code>.el-loading-done</code> via custom Javascript when content has been loaded to remove loading indicators.</span>
							</div>
						</div>
						<div class="el-loading" id="ui_el_loading_example_1">
							<div class="el-loading-indicator">
								<div class="progress-circular progress-circular-inline">
									<div class="progress-circular-wrapper">
										<div class="progress-circular-inner">
											<div class="progress-circular-left">
												<div class="progress-circular-spinner"></div>
											</div>
											<div class="progress-circular-gap"></div>
											<div class="progress-circular-right">
												<div class="progress-circular-spinner"></div>
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class="tile-wrap">
								<div class="tile">
									<div class="tile-inner">
										<span>placeholder</span>
									</div>
								</div>
								<div class="tile">
									<div class="tile-inner">
										<span>placeholder</span>
									</div>
								</div>
								<div class="tile">
									<div class="tile-inner">
										<span>placeholder</span>
									</div>
								</div>
							</div>
						</div>
						<p class="text-right"><a class="btn waves-attach finish-loading" data-target="#ui_el_loading_example_1">Finish Loading</a></p>
						<div class="el-loading" id="ui_el_loading_example_2">
							<div class="el-loading-indicator">
								<div class="progress progress-position-absolute-top">
									<div class="progress-bar-indeterminate"></div>
								</div>
							</div>
							<div class="tile-wrap">
								<div class="tile">
									<div class="tile-inner">
										<span>placeholder</span>
									</div>
								</div>
								<div class="tile">
									<div class="tile-inner">
										<span>placeholder</span>
									</div>
								</div>
								<div class="tile">
									<div class="tile-inner">
										<span>placeholder</span>
									</div>
								</div>
							</div>
						</div>
						<p class="text-right"><a class="btn waves-attach finish-loading" data-target="#ui_el_loading_example_2">Finish Loading</a></p>
						<div class="el-loading" id="ui_el_loading_example_3">
							<div class="el-loading-indicator">
								<div class="progress progress-position-absolute-bottom">
									<div class="load-bar">
										<div class="load-bar-base">
											<div class="load-bar-content">
												<div class="load-bar-progress"></div>
												<div class="load-bar-progress load-bar-progress-brand"></div>
												<div class="load-bar-progress load-bar-progress-green"></div>
												<div class="load-bar-progress load-bar-progress-orange"></div>
											</div>
										</div>
									</div>
									<div class="load-bar">
										<div class="load-bar-base">
											<div class="load-bar-content">
												<div class="load-bar-progress"></div>
												<div class="load-bar-progress load-bar-progress-orange"></div>
												<div class="load-bar-progress load-bar-progress-green"></div>
												<div class="load-bar-progress load-bar-progress-brand"></div>
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class="tile-wrap">
								<div class="tile">
									<div class="tile-inner">
										<span>placeholder</span>
									</div>
								</div>
								<div class="tile">
									<div class="tile-inner">
										<span>placeholder</span>
									</div>
								</div>
								<div class="tile">
									<div class="tile-inner">
										<span>placeholder</span>
									</div>
								</div>
							</div>
						</div>
						<p class="text-right"><a class="btn waves-attach finish-loading" data-target="#ui_el_loading_example_3">Finish Loading</a></p>
						<div class="tile-wrap" id="ui_el_loading_example_wrap">
							<div class="tile tile-collapse">
								<div class="tile-toggle" data-parent="#ui_el_loading_example_wrap" data-target="#ui_el_loading_example_wrap_1" data-toggle="tile">
									<div class="tile-inner">
										<div class="text-overflow">click to expand this tile</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_el_loading_example_wrap_1">
									<div class="el-loading">
										<div class="el-loading-indicator el-loading-indicator-linear">
											<div class="progress progress-position-absolute-top">
												<div class="progress-bar-indeterminate"></div>
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class="tile tile-collapse">
								<div class="tile-toggle" data-parent="#ui_el_loading_example_wrap" data-target="#ui_el_loading_example_wrap_2" data-toggle="tile">
									<div class="tile-inner">
										<div class="text-overflow">click to expand this tile</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_el_loading_example_wrap_2">
									<div class="el-loading">
										<div class="el-loading-indicator el-loading-indicator-linear">
											<div class="progress progress-position-absolute-top">
												<div class="progress-bar-indeterminate"></div>
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class="tile tile-collapse">
								<div class="tile-toggle" data-parent="#ui_el_loading_example_wrap" data-target="#ui_el_loading_example_wrap_3" data-toggle="tile">
									<div class="tile-inner">
										<div class="text-overflow">click to expand this tile</div>
									</div>
								</div>
								<div class="tile-active-show collapse" id="ui_el_loading_example_wrap_3">
									<div class="el-loading">
										<div class="el-loading-indicator el-loading-indicator-linear">
											<div class="progress progress-position-absolute-top">
												<div class="progress-bar-indeterminate"></div>
											</div>
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

