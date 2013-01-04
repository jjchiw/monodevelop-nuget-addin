
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.PackageManagement
{
	public partial class PackagesWidget
	{
		private global::Gtk.HPaned mainPane;
		private global::Gtk.VBox packagesListVBox;
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		private global::Gtk.TreeView packagesTreeView;
		private global::Gtk.VBox packageInfoVBox;
		private global::Gtk.ComboBox packageSourceComboBox;
		private global::Gtk.HBox packageSearchHBox;
		private global::Gtk.Entry packageSearchEntry;
		private global::Gtk.Button packageSearchButton;
		private global::Gtk.Frame packageInfoFrame;
		private global::Gtk.Alignment packageInfoFrameAlignment;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.VBox packageInfoFrameVBox;
		private global::Gtk.HBox packageCreatedByHBox;
		private global::Gtk.Label packageCreatedByLabel;
		private global::Gtk.Label packageCreatedByTextBox;
		private global::Gtk.HBox packageVersionHBox;
		private global::Gtk.Label packageVersionLabel;
		private global::Gtk.Label packageVersionTextBox;
		private global::Gtk.HBox packageLastUpdatedHBox;
		private global::Gtk.Label packageLastUpdatedLabel;
		private global::Gtk.Label packageLastUpdatedTextBox;
		private global::Gtk.HBox packageDownloadsHBox;
		private global::Gtk.Label packageDownloadsLabel;
		private global::Gtk.Label packageDownloadsTextBox;
		private global::Gtk.HBox viewLicenseTermsHBox;
		private global::MonoDevelop.PackageManagement.HyperlinkWidget viewLicenseTermsButton;
		private global::Gtk.HBox moreInformationHBox;
		private global::MonoDevelop.PackageManagement.HyperlinkWidget moreInformationButton;
		private global::Gtk.TextView packageDescriptionTextView;
		private global::Gtk.HButtonBox managePackageButtonBox;
		private global::Gtk.Button addPackageButton;
		private global::Gtk.Button removePackageButton;
		private global::Gtk.Button managePackageButton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.PackageManagement.PackagesWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.PackageManagement.PackagesWidget";
			// Container child MonoDevelop.PackageManagement.PackagesWidget.Gtk.Container+ContainerChild
			this.mainPane = new global::Gtk.HPaned ();
			this.mainPane.CanFocus = true;
			this.mainPane.Name = "mainPane";
			this.mainPane.Position = 322;
			// Container child mainPane.Gtk.Paned+PanedChild
			this.packagesListVBox = new global::Gtk.VBox ();
			this.packagesListVBox.Name = "packagesListVBox";
			this.packagesListVBox.Spacing = 6;
			// Container child packagesListVBox.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.packagesTreeView = new global::Gtk.TreeView ();
			this.packagesTreeView.CanFocus = true;
			this.packagesTreeView.Name = "packagesTreeView";
			this.packagesTreeView.EnableSearch = false;
			this.packagesTreeView.HeadersVisible = false;
			this.GtkScrolledWindow2.Add (this.packagesTreeView);
			this.packagesListVBox.Add (this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.packagesListVBox [this.GtkScrolledWindow2]));
			w2.Position = 0;
			this.mainPane.Add (this.packagesListVBox);
			global::Gtk.Paned.PanedChild w3 = ((global::Gtk.Paned.PanedChild)(this.mainPane [this.packagesListVBox]));
			w3.Resize = false;
			// Container child mainPane.Gtk.Paned+PanedChild
			this.packageInfoVBox = new global::Gtk.VBox ();
			this.packageInfoVBox.Name = "packageInfoVBox";
			this.packageInfoVBox.Spacing = 6;
			// Container child packageInfoVBox.Gtk.Box+BoxChild
			this.packageSourceComboBox = global::Gtk.ComboBox.NewText ();
			this.packageSourceComboBox.Name = "packageSourceComboBox";
			this.packageInfoVBox.Add (this.packageSourceComboBox);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.packageInfoVBox [this.packageSourceComboBox]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child packageInfoVBox.Gtk.Box+BoxChild
			this.packageSearchHBox = new global::Gtk.HBox ();
			this.packageSearchHBox.Name = "packageSearchHBox";
			this.packageSearchHBox.Spacing = 6;
			// Container child packageSearchHBox.Gtk.Box+BoxChild
			this.packageSearchEntry = new global::Gtk.Entry ();
			this.packageSearchEntry.CanFocus = true;
			this.packageSearchEntry.Name = "packageSearchEntry";
			this.packageSearchEntry.IsEditable = true;
			this.packageSearchEntry.InvisibleChar = '●';
			this.packageSearchHBox.Add (this.packageSearchEntry);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.packageSearchHBox [this.packageSearchEntry]));
			w5.Position = 0;
			// Container child packageSearchHBox.Gtk.Box+BoxChild
			this.packageSearchButton = new global::Gtk.Button ();
			this.packageSearchButton.CanFocus = true;
			this.packageSearchButton.Name = "packageSearchButton";
			this.packageSearchButton.UseUnderline = true;
			// Container child packageSearchButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w6 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w7 = new global::Gtk.HBox ();
			w7.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w8 = new global::Gtk.Image ();
			w8.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-find", global::Gtk.IconSize.Menu);
			w7.Add (w8);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w10 = new global::Gtk.Label ();
			w7.Add (w10);
			w6.Add (w7);
			this.packageSearchButton.Add (w6);
			this.packageSearchHBox.Add (this.packageSearchButton);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.packageSearchHBox [this.packageSearchButton]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.packageInfoVBox.Add (this.packageSearchHBox);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.packageInfoVBox [this.packageSearchHBox]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child packageInfoVBox.Gtk.Box+BoxChild
			this.packageInfoFrame = new global::Gtk.Frame ();
			this.packageInfoFrame.Name = "packageInfoFrame";
			this.packageInfoFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			this.packageInfoFrame.LabelYalign = 0F;
			// Container child packageInfoFrame.Gtk.Container+ContainerChild
			this.packageInfoFrameAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.packageInfoFrameAlignment.Name = "packageInfoFrameAlignment";
			// Container child packageInfoFrameAlignment.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w16 = new global::Gtk.Viewport ();
			w16.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.packageInfoFrameVBox = new global::Gtk.VBox ();
			this.packageInfoFrameVBox.Name = "packageInfoFrameVBox";
			this.packageInfoFrameVBox.Spacing = 6;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageCreatedByHBox = new global::Gtk.HBox ();
			this.packageCreatedByHBox.Name = "packageCreatedByHBox";
			this.packageCreatedByHBox.Spacing = 6;
			// Container child packageCreatedByHBox.Gtk.Box+BoxChild
			this.packageCreatedByLabel = new global::Gtk.Label ();
			this.packageCreatedByLabel.Name = "packageCreatedByLabel";
			this.packageCreatedByLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\'bold\'>Created by:</span>");
			this.packageCreatedByLabel.UseMarkup = true;
			this.packageCreatedByHBox.Add (this.packageCreatedByLabel);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.packageCreatedByHBox [this.packageCreatedByLabel]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child packageCreatedByHBox.Gtk.Box+BoxChild
			this.packageCreatedByTextBox = new global::Gtk.Label ();
			this.packageCreatedByTextBox.Name = "packageCreatedByTextBox";
			this.packageCreatedByTextBox.Selectable = true;
			this.packageCreatedByHBox.Add (this.packageCreatedByTextBox);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.packageCreatedByHBox [this.packageCreatedByTextBox]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.packageInfoFrameVBox.Add (this.packageCreatedByHBox);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageCreatedByHBox]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageVersionHBox = new global::Gtk.HBox ();
			this.packageVersionHBox.Name = "packageVersionHBox";
			this.packageVersionHBox.Spacing = 6;
			// Container child packageVersionHBox.Gtk.Box+BoxChild
			this.packageVersionLabel = new global::Gtk.Label ();
			this.packageVersionLabel.Name = "packageVersionLabel";
			this.packageVersionLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\'bold\'>Version:</span>");
			this.packageVersionLabel.UseMarkup = true;
			this.packageVersionHBox.Add (this.packageVersionLabel);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.packageVersionHBox [this.packageVersionLabel]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child packageVersionHBox.Gtk.Box+BoxChild
			this.packageVersionTextBox = new global::Gtk.Label ();
			this.packageVersionTextBox.Name = "packageVersionTextBox";
			this.packageVersionTextBox.Selectable = true;
			this.packageVersionHBox.Add (this.packageVersionTextBox);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.packageVersionHBox [this.packageVersionTextBox]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.packageInfoFrameVBox.Add (this.packageVersionHBox);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageVersionHBox]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageLastUpdatedHBox = new global::Gtk.HBox ();
			this.packageLastUpdatedHBox.Name = "packageLastUpdatedHBox";
			this.packageLastUpdatedHBox.Spacing = 6;
			// Container child packageLastUpdatedHBox.Gtk.Box+BoxChild
			this.packageLastUpdatedLabel = new global::Gtk.Label ();
			this.packageLastUpdatedLabel.Name = "packageLastUpdatedLabel";
			this.packageLastUpdatedLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\'bold\'>Last Updated:</span>");
			this.packageLastUpdatedLabel.UseMarkup = true;
			this.packageLastUpdatedHBox.Add (this.packageLastUpdatedLabel);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.packageLastUpdatedHBox [this.packageLastUpdatedLabel]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child packageLastUpdatedHBox.Gtk.Box+BoxChild
			this.packageLastUpdatedTextBox = new global::Gtk.Label ();
			this.packageLastUpdatedTextBox.Name = "packageLastUpdatedTextBox";
			this.packageLastUpdatedTextBox.Selectable = true;
			this.packageLastUpdatedHBox.Add (this.packageLastUpdatedTextBox);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.packageLastUpdatedHBox [this.packageLastUpdatedTextBox]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.packageInfoFrameVBox.Add (this.packageLastUpdatedHBox);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageLastUpdatedHBox]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageDownloadsHBox = new global::Gtk.HBox ();
			this.packageDownloadsHBox.Name = "packageDownloadsHBox";
			this.packageDownloadsHBox.Spacing = 6;
			// Container child packageDownloadsHBox.Gtk.Box+BoxChild
			this.packageDownloadsLabel = new global::Gtk.Label ();
			this.packageDownloadsLabel.Name = "packageDownloadsLabel";
			this.packageDownloadsLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\'bold\'>Downloads:</span>");
			this.packageDownloadsLabel.UseMarkup = true;
			this.packageDownloadsHBox.Add (this.packageDownloadsLabel);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.packageDownloadsHBox [this.packageDownloadsLabel]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child packageDownloadsHBox.Gtk.Box+BoxChild
			this.packageDownloadsTextBox = new global::Gtk.Label ();
			this.packageDownloadsTextBox.Name = "packageDownloadsTextBox";
			this.packageDownloadsTextBox.Selectable = true;
			this.packageDownloadsHBox.Add (this.packageDownloadsTextBox);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.packageDownloadsHBox [this.packageDownloadsTextBox]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.packageInfoFrameVBox.Add (this.packageDownloadsHBox);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageDownloadsHBox]));
			w28.Position = 3;
			w28.Expand = false;
			w28.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.viewLicenseTermsHBox = new global::Gtk.HBox ();
			this.viewLicenseTermsHBox.Name = "viewLicenseTermsHBox";
			this.viewLicenseTermsHBox.Spacing = 6;
			// Container child viewLicenseTermsHBox.Gtk.Box+BoxChild
			this.viewLicenseTermsButton = new global::MonoDevelop.PackageManagement.HyperlinkWidget ();
			this.viewLicenseTermsButton.Events = ((global::Gdk.EventMask)(256));
			this.viewLicenseTermsButton.Name = "viewLicenseTermsButton";
			this.viewLicenseTermsButton.Uri = "";
			this.viewLicenseTermsButton.Label = "View License Terms";
			this.viewLicenseTermsHBox.Add (this.viewLicenseTermsButton);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.viewLicenseTermsHBox [this.viewLicenseTermsButton]));
			w29.Position = 0;
			this.packageInfoFrameVBox.Add (this.viewLicenseTermsHBox);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.viewLicenseTermsHBox]));
			w30.Position = 4;
			w30.Expand = false;
			w30.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.moreInformationHBox = new global::Gtk.HBox ();
			this.moreInformationHBox.Name = "moreInformationHBox";
			// Container child moreInformationHBox.Gtk.Box+BoxChild
			this.moreInformationButton = new global::MonoDevelop.PackageManagement.HyperlinkWidget ();
			this.moreInformationButton.Events = ((global::Gdk.EventMask)(256));
			this.moreInformationButton.Name = "moreInformationButton";
			this.moreInformationButton.Uri = "";
			this.moreInformationButton.Label = "More Information";
			this.moreInformationHBox.Add (this.moreInformationButton);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.moreInformationHBox [this.moreInformationButton]));
			w31.Position = 0;
			this.packageInfoFrameVBox.Add (this.moreInformationHBox);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.moreInformationHBox]));
			w32.Position = 5;
			w32.Expand = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageDescriptionTextView = new global::Gtk.TextView ();
			this.packageDescriptionTextView.CanFocus = true;
			this.packageDescriptionTextView.Name = "packageDescriptionTextView";
			this.packageDescriptionTextView.Editable = false;
			this.packageDescriptionTextView.CursorVisible = false;
			this.packageDescriptionTextView.WrapMode = ((global::Gtk.WrapMode)(2));
			this.packageInfoFrameVBox.Add (this.packageDescriptionTextView);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageDescriptionTextView]));
			w33.Position = 6;
			w16.Add (this.packageInfoFrameVBox);
			this.GtkScrolledWindow.Add (w16);
			this.packageInfoFrameAlignment.Add (this.GtkScrolledWindow);
			this.packageInfoFrame.Add (this.packageInfoFrameAlignment);
			this.packageInfoVBox.Add (this.packageInfoFrame);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.packageInfoVBox [this.packageInfoFrame]));
			w38.Position = 2;
			// Container child packageInfoVBox.Gtk.Box+BoxChild
			this.managePackageButtonBox = new global::Gtk.HButtonBox ();
			this.managePackageButtonBox.Name = "managePackageButtonBox";
			this.managePackageButtonBox.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child managePackageButtonBox.Gtk.ButtonBox+ButtonBoxChild
			this.addPackageButton = new global::Gtk.Button ();
			this.addPackageButton.CanFocus = true;
			this.addPackageButton.Name = "addPackageButton";
			this.addPackageButton.UseUnderline = true;
			this.addPackageButton.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.managePackageButtonBox.Add (this.addPackageButton);
			global::Gtk.ButtonBox.ButtonBoxChild w39 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.managePackageButtonBox [this.addPackageButton]));
			w39.Expand = false;
			w39.Fill = false;
			// Container child managePackageButtonBox.Gtk.ButtonBox+ButtonBoxChild
			this.removePackageButton = new global::Gtk.Button ();
			this.removePackageButton.CanFocus = true;
			this.removePackageButton.Name = "removePackageButton";
			this.removePackageButton.UseUnderline = true;
			this.removePackageButton.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.managePackageButtonBox.Add (this.removePackageButton);
			global::Gtk.ButtonBox.ButtonBoxChild w40 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.managePackageButtonBox [this.removePackageButton]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			// Container child managePackageButtonBox.Gtk.ButtonBox+ButtonBoxChild
			this.managePackageButton = new global::Gtk.Button ();
			this.managePackageButton.CanFocus = true;
			this.managePackageButton.Name = "managePackageButton";
			this.managePackageButton.UseUnderline = true;
			this.managePackageButton.Label = global::Mono.Unix.Catalog.GetString ("Manage");
			this.managePackageButtonBox.Add (this.managePackageButton);
			global::Gtk.ButtonBox.ButtonBoxChild w41 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.managePackageButtonBox [this.managePackageButton]));
			w41.Position = 2;
			w41.Expand = false;
			w41.Fill = false;
			this.packageInfoVBox.Add (this.managePackageButtonBox);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.packageInfoVBox [this.managePackageButtonBox]));
			w42.PackType = ((global::Gtk.PackType)(1));
			w42.Position = 3;
			w42.Expand = false;
			w42.Fill = false;
			this.mainPane.Add (this.packageInfoVBox);
			this.Add (this.mainPane);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.packageInfoFrameVBox.Hide ();
			this.addPackageButton.Hide ();
			this.removePackageButton.Hide ();
			this.managePackageButton.Hide ();
			this.Hide ();
			this.packageSourceComboBox.Changed += new global::System.EventHandler (this.PackageSourceChanged);
			this.packageSearchEntry.Activated += new global::System.EventHandler (this.PackageSearchEntryActivated);
			this.packageSearchButton.Clicked += new global::System.EventHandler (this.SearchButtonClicked);
			this.addPackageButton.Clicked += new global::System.EventHandler (this.OnAddPackageButtonClicked);
			this.removePackageButton.Clicked += new global::System.EventHandler (this.RemovePackageButtonClicked);
			this.managePackageButton.Clicked += new global::System.EventHandler (this.ManagePackagesButtonClicked);
		}
	}
}
