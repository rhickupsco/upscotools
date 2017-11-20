<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-text-field.aspx.cs" Inherits="ui_text_field" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Text Fields</h1>
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
									<p>Text fields allow the user to input and select text. The examples form below demonstrate customized form elements for a more consistent rendering across browsers and devices.</p>
								</div>
							</div>
						</div>
						<form>
							<fieldset>
								<legend class="access-hide">Text Fields</legend>
								<h2 class="content-sub-heading">Input</h2>
								<div class="card">
									<div class="card-main">
										<div class="card-inner">
											<div class="form-group form-group-label">
												<label class="floating-label" for="ui_floating_label_example">Input</label>
												<input class="form-control" id="ui_floating_label_example" type="text">
											</div>
											<div class="form-group form-group-label">
												<label class="floating-label" for="ui_floating_label_example_value">Input with Value</label>
												<input class="form-control" id="ui_floating_label_example_value" type="text" value="something has already been written down">
											</div>
<pre>
&lt;div class="form-group form-group-label"&gt;
    &lt;label class="floating-label" for="..."&gt; ... &lt;/label&gt;
    &lt;input class="form-control" id="..." type="text"&gt;
&lt;/div&gt;
</pre>
										</div>
									</div>
								</div>
								<h2 class="content-sub-heading">Select</h2>
								<div class="card">
									<div class="card-main">
										<div class="card-inner">
											<div class="form-group form-group-label">
												<label class="floating-label" for="ui_floating_label_example_select">انتخاب کنید</label>
												<select class="form-control" id="ui_floating_label_example_select">
													<option></option>
													<option value="1">1</option>
													<option value="2">2</option>
													<option value="3">3</option>
												</select>
											</div>
<pre>
&lt;div class="form-group form-group-label"&gt;
    &lt;label class="floating-label" for="..."&gt; ... &lt;/label&gt;
    &lt;select class="form-control" id="..."&gt;
        &lt;option value="..."&gt; ... &lt;/option&gt;
        ...
    &lt;/select&gt;
&lt;/div&gt;
</pre>
										</div>
									</div>
								</div>
								<h2 class="content-sub-heading">Textarea</h2>
								<div class="card">
									<div class="card-main">
										<div class="card-inner">
											<div class="form-group form-group-label">
												<label class="floating-label" for="ui_floating_label_example_textarea_autosize">Auto Expanding Textarea</label>
												<textarea class="form-control textarea-autosize" id="ui_floating_label_example_textarea_autosize" rows="1"></textarea>
											</div>
<pre>
&lt;div class="form-group form-group-label"&gt;
    &lt;label class="floating-label" for="..."&gt; ... &lt;/label&gt;
    &lt;textarea class="form-control textarea-autosize" id="..." rows="1"&gt;&lt;/textarea&gt;
&lt;/div&gt;
</pre>
											<div class="form-group form-group-label">
												<label class="floating-label" for="ui_floating_label_example_textarea_normal">Normal Textarea</label>
												<textarea class="form-control" id="ui_floating_label_example_textarea_normal" rows="3"></textarea>
											</div>
<pre>
&lt;div class="form-group form-group-label"&gt;
    &lt;label class="floating-label" for="..."&gt; ... &lt;/label&gt;
    &lt;textarea class="form-control" id="..." rows="..."&gt;&lt;/textarea&gt;
&lt;/div&gt;
</pre>
										</div>
									</div>
								</div>
								<div class="card">
									<div class="card-main">
										<div class="card-inner">
											<div class="form-group form-group-label">
												<label class="floating-label" for="ui_floating_label_example_disabled">Disabled Input</label>
												<input class="form-control" id="ui_floating_label_example_disabled" type="text" disabled>
												<div class="form-help">
													<code>disabled</code>
												</div>
											</div>
											<div class="form-group form-group-label">
												<label class="floating-label" for="ui_floating_label_example_disabled_value">Disabled Input with Value</label>
												<input class="form-control" id="ui_floating_label_example_disabled_value" type="text" value="something has already been written down" disabled>
												<div class="form-help">
													<code>disabled</code>
												</div>
											</div>
											<div class="form-group form-group-label form-group-brand">
												<label class="floating-label" for="ui_floating_label_example_brand">Brand Input</label>
												<input class="form-control" id="ui_floating_label_example_brand" type="text">
												<div class="form-help">
													<code>.form-group-brand</code>
												</div>
											</div>
											<div class="form-group form-group-label form-group-brand-accent">
												<label class="floating-label" for="ui_floating_label_example_brand_accent">Brand Accent Input</label>
												<input class="form-control" id="ui_floating_label_example_brand_accent" type="text">
												<div class="form-help">
													<code>.form-group-brand-accent</code>
												</div>
											</div>
											<div class="form-group form-group-label form-group-green">
												<label class="floating-label" for="ui_floating_label_example_green">Green Input</label>
												<input class="form-control" id="ui_floating_label_example_green" type="text">
												<div class="form-help">
													<code>.form-group-green</code>
												</div>
											</div>
											<div class="form-group form-group-label form-group-orange">
												<label class="floating-label" for="ui_floating_label_example_orange">Orange Input</label>
												<input class="form-control" id="ui_floating_label_example_orange" type="text">
												<div class="form-help">
													<code>.form-group-orange</code>
												</div>
											</div>
											<div class="form-group form-group-label form-group-red">
												<label class="floating-label" for="ui_floating_label_example_red">Red Input</label>
												<input class="form-control" id="ui_floating_label_example_red" type="text">
												<div class="form-help">
													<code>.form-group-red</code>
												</div>
											</div>
										</div>
									</div>
								</div>
							</fieldset>
							<button class="access-hide" type="submit">Submit Button</button>
						</form>
					</section>
				</div>
			</div>
		</div>
	</main>
</asp:Content>

