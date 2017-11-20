<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ui-selection-control.aspx.cs" Inherits="ui_selection_control" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main class="content">
		<div class="content-header ui-content-header">
			<div class="container">
				<div class="row">
					<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2">
						<h1 class="content-heading">Selection Controls</h1>
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
									<p>Selection controls allow the user to select options. There are three kinds: checkboxes, radio buttons, and switches. Selection controls use the theme’s accent colour.</p>
								</div>
							</div>
						</div>
						<form>
							<fieldset>
								<legend class="access-hide">Selection Controls</legend>
								<h2 class="content-sub-heading">Checkboxes</h2>
								<div class="card">
									<div class="card-main">
										<div class="card-inner">
											<div class="form-group">
												<div class="checkbox checkbox-adv">
													<label for="ui_checkbox_example_1">
														<input class="access-hide" id="ui_checkbox_example_1" name="ui_checkbox_example" type="checkbox">گزینه 1
														<span class="checkbox-circle"></span><span class="checkbox-circle-check"></span><span class="checkbox-circle-icon icon">done</span>
													</label>
												</div>
												<div class="checkbox checkbox-adv">
													<label for="ui_checkbox_example_2">
														<input checked class="access-hide" id="ui_checkbox_example_2" name="ui_checkbox_example" type="checkbox">گزینه 2
														<span class="checkbox-circle"></span><span class="checkbox-circle-check"></span><span class="checkbox-circle-icon icon">done</span>
													</label>
												</div>
											</div>
<pre>
&lt;div class="checkbox checkbox-adv"&gt;
    &lt;label for="..."&gt;
        &lt;input class="access-hide" id="..." name="..." type="checkbox"&gt;...
        &lt;span class="checkbox-circle"&gt;&lt;/span&gt;&lt;span class="checkbox-circle-check"&gt;&lt;/span&gt;&lt;span class="checkbox-circle-icon icon"&gt;done&lt;/span&gt;
    &lt;/label&gt;
&lt;/div&gt;
</pre>
										</div>
									</div>
								</div>
								<div class="card">
									<div class="card-main">
										<div class="card-inner">
											<div class="form-group">
												<div class="checkbox checkbox-adv checkbox-inline disabled">
													<label for="ui_checkbox_example_1_disabled">
														<input class="access-hide" disabled id="ui_checkbox_example_1_disabled" name="ui_checkbox_example_disabled" type="checkbox">Disabled Option 1
														<span class="checkbox-circle"></span><span class="checkbox-circle-check"></span><span class="checkbox-circle-icon icon">done</span>
													</label>
												</div>
												<div class="checkbox checkbox-adv checkbox-inline disabled">
													<label for="ui_checkbox_example_2_disabled">
														<input class="access-hide" disabled id="ui_checkbox_example_2_disabled" name="ui_checkbox_example_disabled" type="checkbox" checked="">Disabled Option 2
														<span class="checkbox-circle"></span><span class="checkbox-circle-check"></span><span class="checkbox-circle-icon icon">done</span>
													</label>
												</div>
											</div>
											<p><code>disabled</code>, <code>.disabled</code> &amp; <code>.checkbox-inline</code></p>
										</div>
									</div>
								</div>
								<h2 class="content-sub-heading">Radio Buttons</h2>
								<div class="card">
									<div class="card-main">
										<div class="card-inner">
											<div class="form-group">
												<div class="radiobtn radiobtn-adv">
													<label for="input_radio_example_1">
														<input class="access-hide" id="input_radio_example_1" name="input_radio_example" type="radio">Option 1
														<span class="radiobtn-circle"></span><span class="radiobtn-circle-check"></span>
													</label>
												</div>
												<div class="radiobtn radiobtn-adv">
													<label for="input_radio_example_2">
														<input checked class="access-hide" id="input_radio_example_2" name="input_radio_example" type="radio">Option 2
														<span class="radiobtn-circle"></span><span class="radiobtn-circle-check"></span>
													</label>
												</div>
											</div>
<pre>
&lt;div class="radiobtn radiobtn-adv"&gt;
    &lt;label for="..."&gt;
        &lt;input class="access-hide" id="..." name="..." type="radio"&gt;...
        &lt;span class="radiobtn-circle"&gt;&lt;/span&gt;&lt;span class="radiobtn-circle-check"&gt;&lt;/span&gt;
    &lt;/label&gt;
&lt;/div&gt;
</pre>
										</div>
									</div>
								</div>
								<div class="card">
									<div class="card-main">
										<div class="card-inner">
											<div class="form-group">
												<div class="radiobtn radiobtn-adv radiobtn-inline disabled">
													<label for="input_radio_example_1_disabled">
														<input class="access-hide" disabled id="input_radio_example_1_disabled" name="input_radio_example_disabled" type="radio">Disabled Option 1
														<span class="radiobtn-circle"></span><span class="radiobtn-circle-check"></span>
													</label>
												</div>
												<div class="radiobtn radiobtn-adv radiobtn-inline disabled">
													<label for="input_radio_example_2_disabled">
														<input checked class="access-hide" disabled id="input_radio_example_2_disabled" name="input_radio_example_disabled" type="radio">Disabled Option 2
														<span class="radiobtn-circle"></span><span class="radiobtn-circle-check"></span>
													</label>
												</div>
											</div>
											<p><code>disabled</code>, <code>.disabled</code> &amp; <code>.radiobtn-inline</code></p>
										</div>
									</div>
								</div>
								<h2 class="content-sub-heading">Switches</h2>
								<div class="card">
									<div class="card-main">
										<div class="card-inner">
											<div class="form-group">
												<div class="checkbox switch">
													<label for="ui_switch_example_1">
														<input class="access-hide" id="ui_switch_example_1" name="ui_switch_example" type="checkbox"><span class="switch-toggle"></span>On/Off Switch
													</label>
												</div>
											</div>
											<div class="form-group">
												<div class="checkbox switch">
													<label for="ui_switch_example_2">
														<input checked class="access-hide" id="ui_switch_example_2" name="ui_switch_example" type="checkbox"><span class="switch-toggle"></span>On/Off Switch
													</label>
												</div>
											</div>
<pre>
&lt;div class="checkbox switch"&gt;
    &lt;label for="..."&gt;
        &lt;input class="access-hide" id="..." name="..." type="checkbox"&gt;&lt;span class="switch-toggle"&gt;&lt;/span&gt;...
    &lt;/label&gt;
&lt;/div&gt;
</pre>
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

