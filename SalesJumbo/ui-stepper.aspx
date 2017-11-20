<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-stepper.aspx.cs" Inherits="ui_stepper" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Steppers</h1>
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
									<p>Steppers convey progress through numbered steps. They may also be used for navigation.</p>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Horizontal Steppers</h2>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
									<p>Horizontal steppers are ideal when the contents of one step depend on an earlier step.</p>
									<p>Avoid using long step names in horizontal steppers.</p>
								</div>
							</div>
						</div>
						<div class="tile-wrap">
							<div class="tile">
								<div class="stepper-horiz">
									<div class="stepper-horiz-inner">
										<div class="stepper done">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">1</span>
											</div>
											<span class="stepper-text">Step 1</span>
										</div>
										<div class="stepper active">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">2</span>
											</div>
											<span class="stepper-text">
												Step 2<br>
												<small class="stepper-text-sub text-black-hint">Optional</small>
											</span>
										</div>
										<div class="stepper">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">3</span>
											</div>
											<span class="stepper-text">Step 3</span>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
<pre>
&lt;div class="stpper-horiz"&gt;
    &lt;div class="stepper-horiz-inner"&gt;
        &lt;div class="stepper done"&gt;
            &lt;div class="stepper-step"&gt;
                &lt;i class="icon stepper-step-icon"&gt;check&lt;/i&gt;
                &lt;span class="stepper-step-num"&gt;1&lt;/span&gt;
            &lt;/div&gt;
            &lt;span class="stepper-text"&gt;Step 1&lt;/span&gt;
        &lt;/div&gt;
        &lt;div class="stepper active"&gt;
            &lt;div class="stepper-step"&gt;
                &lt;i class="icon stepper-step-icon"&gt;check&lt;/i&gt;
                &lt;span class="stepper-step-num"&gt;2&lt;/span&gt;
            &lt;/div&gt;
            &lt;span class="stepper-text"&gt;Step 2&lt;/span&gt;
        &lt;/div&gt;
        &lt;div class="stepper"&gt;
            &lt;div class="stepper-step"&gt;
                &lt;i class="icon stepper-step-icon"&gt;check&lt;/i&gt;
                &lt;span class="stepper-step-num"&gt;3&lt;/span&gt;
            &lt;/div&gt;
            &lt;span class="stepper-text"&gt;Step 3&lt;/span&gt;
        &lt;/div&gt;
    &lt;/div&gt;
&lt;/div&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="tile-wrap">
							<div class="tile">
								<div class="stepper-horiz stepper-horiz-alt">
									<div class="stepper-horiz-inner">
										<div class="stepper done">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">1</span>
											</div>
											<span class="stepper-text">Step 1</span>
										</div>
										<div class="stepper active">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">2</span>
											</div>
											<span class="stepper-text">
												Step 2<br>
												<small class="stepper-text-sub text-black-hint">Optional</small>
											</span>
										</div>
										<div class="stepper">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">3</span>
											</div>
											<span class="stepper-text">Step 3</span>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-inner">
<pre>
&lt;div class="stpper-horiz stepper-horiz-alt"&gt;
    &lt;div class="stepper-horiz-inner"&gt;
        &lt;div class="stepper done"&gt;
            ...
        &lt;/div&gt;
        &lt;div class="stepper active"&gt;
            ...
        &lt;/div&gt;
        &lt;div class="stepper"&gt;
            ...
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
										<h3 class="h5 margin-bottom-no margin-top-no">Linear Steppers</h3>
									</div>
								</div>
								<div class="card-inner">
									<p>Linear steppers require users to complete one step in order to move on to the next.</p>
									<p>Each linear step must be completed before proceeding to the next one.</p>
								</div>
							</div>
						</div>
						<div class="tile-wrap">
							<div class="tile">
								<div class="stepper-horiz">
									<div class="stepper-horiz-inner">
										<div class="stepper active">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">1</span>
											</div>
											<span class="stepper-text">Step 1</span>
										</div>
										<div class="stepper">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">2</span>
											</div>
											<span class="stepper-text">
												Step 2<br>
												<small class="stepper-text-sub text-black-hint">Optional</small>
											</span>
										</div>
										<div class="stepper">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">3</span>
											</div>
											<span class="stepper-text">Step 3</span>
										</div>
									</div>
								</div>
							</div>
							<div class="tile">
								<div class="stepper-horiz">
									<div class="stepper-horiz-inner">
										<div class="stepper done">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">1</span>
											</div>
											<span class="stepper-text">Step 1</span>
										</div>
										<div class="stepper active">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">2</span>
											</div>
											<span class="stepper-text">
												Step 2<br>
												<small class="stepper-text-sub text-black-hint">Optional</small>
											</span>
										</div>
										<div class="stepper">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">3</span>
											</div>
											<span class="stepper-text">Step 3</span>
										</div>
									</div>
								</div>
							</div>
							<div class="tile">
								<div class="stepper-horiz">
									<div class="stepper-horiz-inner">
										<div class="stepper done">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">1</span>
											</div>
											<span class="stepper-text">Step 1</span>
										</div>
										<div class="stepper done">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">2</span>
											</div>
											<span class="stepper-text">
												Step 2<br>
												<small class="stepper-text-sub text-black-hint">Optional</small>
											</span>
										</div>
										<div class="stepper active">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">3</span>
											</div>
											<span class="stepper-text">Step 3</span>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="card">
							<div class="card-main">
								<div class="card-header">
									<div class="card-inner">
										<h3 class="h5 margin-bottom-no margin-top-no">Non-linear Steppers</h3>
									</div>
								</div>
								<div class="card-inner">
									<p>Non-linear steppers allow users to enter a multi-step flow at any point.</p>
									<p>Non-linear steps may be completed in any order.</p>
<pre>
&lt;div class="stpper-horiz stepper-horiz-alt"&gt;
    &lt;a class="stepper stepper-control waves-attach" ...&gt;
        ...
    &lt;/a&gt;
    ...
&lt;/div&gt;
</pre>
								</div>
							</div>
						</div>
						<div class="tile-wrap">
							<div class="tile">
								<div class="stepper-horiz">
									<div class="stepper-horiz-inner">
										<a class="stepper stepper-control active waves-attach" href="javascript:void(0)">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">1</span>
											</div>
											<span class="stepper-text">Step 1</span>
										</a>
										<a class="stepper stepper-control waves-attach" href="javascript:void(0)">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">2</span>
											</div>
											<span class="stepper-text">
												Step 2<br>
												<small class="stepper-text-sub text-black-hint">Optional</small>
											</span>
										</a>
										<a class="stepper stepper-control waves-attach" href="javascript:void(0)">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">3</span>
											</div>
											<span class="stepper-text">Step 3</span>
										</a>
									</div>
								</div>
							</div>
							<div class="tile">
								<div class="stepper-horiz">
									<div class="stepper-horiz-inner">
										<a class="stepper stepper-control done waves-attach" href="javascript:void(0)">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">1</span>
											</div>
											<span class="stepper-text">Step 1</span>
										</a>
										<a class="stepper stepper-control waves-attach" href="javascript:void(0)">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">2</span>
											</div>
											<span class="stepper-text">
												Step 2<br>
												<small class="stepper-text-sub text-black-hint">Optional</small>
											</span>
										</a>
										<a class="stepper stepper-control active waves-attach" href="javascript:void(0)">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">3</span>
											</div>
											<span class="stepper-text">Step 3</span>
										</a>
									</div>
								</div>
							</div>
							<div class="tile">
								<div class="stepper-horiz">
									<div class="stepper-horiz-inner">
										<a class="stepper stepper-control done waves-attach" href="javascript:void(0)">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">1</span>
											</div>
											<span class="stepper-text">Step 1</span>
										</a>
										<a class="stepper stepper-control active waves-attach" href="javascript:void(0)">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">2</span>
											</div>
											<span class="stepper-text">
												Step 2<br>
												<small class="stepper-text-sub text-black-hint">Optional</small>
											</span>
										</a>
										<a class="stepper stepper-control done waves-attach" href="javascript:void(0)">
											<div class="stepper-step">
												<i class="icon stepper-step-icon">check</i>
												<span class="stepper-step-num">3</span>
											</div>
											<span class="stepper-text">Step 3</span>
										</a>
									</div>
								</div>
							</div>
						</div>
						<h2 class="content-sub-heading">Vertical Steppers</h2>
						<div class="stepper-vert">
							<div class="stepper-vert-inner">
								<div class="stepper done">
									<div class="stepper-step">
										<i class="icon stepper-step-icon">check</i>
										<span class="stepper-step-num">1</span>
									</div>
									<span class="stepper-text">Step 1</span>
								</div>
								<div class="stepper active">
									<div class="stepper-step">
										<i class="icon stepper-step-icon">check</i>
										<span class="stepper-step-num">2</span>
									</div>
									<span class="stepper-text">
										Step 2<br>
										<small class="stepper-text-sub text-black-hint">Optional</small>
									</span>
								</div>
								<div class="stepper-vert-content">
									<p class="h5">Vertical Steppers</p>
									<p>Vertical steppers are designed for narrow screen sizes. They are ideal for mobile.</p>
									<p>Vertical steppers can be used in mobile as-is. Simply ensure the contents for each step are responsive.</p>
									<p>
										<a class="btn btn-brand margin-right-sm waves-attach waves-light" href="javascript:void(0)">Continue</a>
										<a class="btn btn-flat margin-right-sm waves-attach" href="javascript:void(0)">Cancel</a>
									</p>
								</div>
								<div class="stepper">
									<div class="stepper-step">
										<i class="icon stepper-step-icon">check</i>
										<span class="stepper-step-num">3</span>
									</div>
									<span class="stepper-text">Step 3</span>
								</div>
							</div>
						</div>
<pre>
&lt;div class="stpper-vert"&gt;
    &lt;div class="stpper-vert-inner"&gt;
        &lt;div class="stepper done"&gt;
            &lt;div class="stepper-step"&gt;
                &lt;i class="icon stepper-step-icon"&gt;check&lt;/i&gt;
                &lt;span class="stepper-step-num"&gt;1&lt;/span&gt;
            &lt;/div&gt;
            &lt;span class="stepper-text"&gt;Step 1&lt;/span&gt;
        &lt;/div&gt;
        &lt;div class="stepper-vert-content"&gt;
           ...
        &lt;/div&gt;
        &lt;div class="stepper active"&gt;
            &lt;div class="stepper-step"&gt;
                &lt;i class="icon stepper-step-icon"&gt;check&lt;/i&gt;
                &lt;span class="stepper-step-num"&gt;2&lt;/span&gt;
            &lt;/div&gt;
            &lt;span class="stepper-text"&gt;Step 2&lt;/span&gt;
        &lt;/div&gt;
        &lt;div class="stepper-vert-content"&gt;
           ...
        &lt;/div&gt;
        &lt;div class="stepper"&gt;
            &lt;div class="stepper-step"&gt;
                &lt;i class="icon stepper-step-icon"&gt;check&lt;/i&gt;
                &lt;span class="stepper-step-num"&gt;3&lt;/span&gt;
            &lt;/div&gt;
            &lt;span class="stepper-text"&gt;Step 3&lt;/span&gt;
        &lt;/div&gt;
        &lt;div class="stepper-vert-content"&gt;
           ...
        &lt;/div&gt;
    &lt;/div&gt;
&lt;/div&gt;
</pre>
						<div class="stepper-vert">
							<div class="stepper-vert-inner">
								<a class="stepper stepper-control done waves-attach" href="javascript:void(0)">
									<div class="stepper-step">
										<i class="icon stepper-step-icon">check</i>
										<span class="stepper-step-num">1</span>
									</div>
									<span class="stepper-text">Step 1</span>
								</a>
								<a class="stepper stepper-control waves-attach" href="javascript:void(0)">
									<div class="stepper-step">
										<i class="icon stepper-step-icon">check</i>
										<span class="stepper-step-num">2</span>
									</div>
									<span class="stepper-text">
										Step 2<br>
										<small class="stepper-text-sub text-black-hint">Optional</small>
									</span>
								</a>
								<a class="stepper stepper-control active waves-attach" href="javascript:void(0)">
									<div class="stepper-step">
										<i class="icon stepper-step-icon">check</i>
										<span class="stepper-step-num">3</span>
									</div>
									<span class="stepper-text">Step 3</span>
								</a>
							</div>
						</div>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

