// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Monobjc.Gui {
    
    
    internal partial class MonobjcOptionsPanelWidget {
        
        private Gtk.VBox vbox1;
        
        private Gtk.Label label1;
        
        private Gtk.Alignment alignment1;
        
        private Gtk.Table table1;
        
        private MonoDevelop.Projects.Gui.ProjectFileEntry appIconPicker;
        
        private Gtk.Entry bundleIdEntry;
        
        private Gtk.Entry bundleVersionEntry;
        
        private Gtk.Entry devRegionEntry;
        
        private Gtk.Entry displayNameEntry;
        
        private Gtk.Label label2;
        
        private Gtk.Label label3;
        
        private Gtk.Label label4;
        
        private Gtk.Label label5;
        
        private Gtk.Label label6;
        
        private Gtk.Label label7;
        
        private MonoDevelop.Projects.Gui.ProjectFileEntry mainNibPicker;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Monobjc.Gui.MonobjcOptionsPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Monobjc.Gui.MonobjcOptionsPanelWidget";
            // Container child MonoDevelop.Monobjc.Gui.MonobjcOptionsPanelWidget.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 12;
            // Container child vbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("<b>Application Bundle</b>");
            this.label1.UseMarkup = true;
            this.vbox1.Add(this.label1);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.label1]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            this.alignment1.LeftPadding = ((uint)(12));
            // Container child alignment1.Gtk.Container+ContainerChild
            this.table1 = new Gtk.Table(((uint)(6)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.appIconPicker = new MonoDevelop.Projects.Gui.ProjectFileEntry();
            this.appIconPicker.Name = "appIconPicker";
            this.appIconPicker.EntryIsEditable = false;
            this.table1.Add(this.appIconPicker);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.appIconPicker]));
            w2.TopAttach = ((uint)(3));
            w2.BottomAttach = ((uint)(4));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.bundleIdEntry = new Gtk.Entry();
            this.bundleIdEntry.CanFocus = true;
            this.bundleIdEntry.Name = "bundleIdEntry";
            this.bundleIdEntry.IsEditable = true;
            this.bundleIdEntry.InvisibleChar = '●';
            this.table1.Add(this.bundleIdEntry);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.bundleIdEntry]));
            w3.TopAttach = ((uint)(1));
            w3.BottomAttach = ((uint)(2));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.bundleVersionEntry = new Gtk.Entry();
            this.bundleVersionEntry.CanFocus = true;
            this.bundleVersionEntry.Name = "bundleVersionEntry";
            this.bundleVersionEntry.IsEditable = true;
            this.bundleVersionEntry.InvisibleChar = '●';
            this.table1.Add(this.bundleVersionEntry);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.bundleVersionEntry]));
            w4.TopAttach = ((uint)(2));
            w4.BottomAttach = ((uint)(3));
            w4.LeftAttach = ((uint)(1));
            w4.RightAttach = ((uint)(2));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.devRegionEntry = new Gtk.Entry();
            this.devRegionEntry.CanFocus = true;
            this.devRegionEntry.Name = "devRegionEntry";
            this.devRegionEntry.IsEditable = true;
            this.devRegionEntry.InvisibleChar = '●';
            this.table1.Add(this.devRegionEntry);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.devRegionEntry]));
            w5.TopAttach = ((uint)(5));
            w5.BottomAttach = ((uint)(6));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.displayNameEntry = new Gtk.Entry();
            this.displayNameEntry.CanFocus = true;
            this.displayNameEntry.Name = "displayNameEntry";
            this.displayNameEntry.IsEditable = true;
            this.displayNameEntry.InvisibleChar = '●';
            this.table1.Add(this.displayNameEntry);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.displayNameEntry]));
            w6.LeftAttach = ((uint)(1));
            w6.RightAttach = ((uint)(2));
            w6.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Main _interface file:");
            this.label2.UseUnderline = true;
            this.table1.Add(this.label2);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.label2]));
            w7.TopAttach = ((uint)(4));
            w7.BottomAttach = ((uint)(5));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Development _region:");
            this.label3.UseUnderline = true;
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w8.TopAttach = ((uint)(5));
            w8.BottomAttach = ((uint)(6));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.Xalign = 0F;
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("Application i_con:");
            this.label4.UseUnderline = true;
            this.table1.Add(this.label4);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table1[this.label4]));
            w9.TopAttach = ((uint)(3));
            w9.BottomAttach = ((uint)(4));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.Xalign = 0F;
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("Bundle _version:");
            this.label5.UseUnderline = true;
            this.table1.Add(this.label5);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table1[this.label5]));
            w10.TopAttach = ((uint)(2));
            w10.BottomAttach = ((uint)(3));
            w10.XOptions = ((Gtk.AttachOptions)(4));
            w10.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.Xalign = 0F;
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("_Display name:");
            this.label6.UseUnderline = true;
            this.table1.Add(this.label6);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table1[this.label6]));
            w11.XOptions = ((Gtk.AttachOptions)(4));
            w11.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Bundle _identifier:");
            this.label7.UseUnderline = true;
            this.table1.Add(this.label7);
            Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table1[this.label7]));
            w12.TopAttach = ((uint)(1));
            w12.BottomAttach = ((uint)(2));
            w12.XOptions = ((Gtk.AttachOptions)(4));
            w12.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.mainNibPicker = new MonoDevelop.Projects.Gui.ProjectFileEntry();
            this.mainNibPicker.Name = "mainNibPicker";
            this.mainNibPicker.EntryIsEditable = false;
            this.table1.Add(this.mainNibPicker);
            Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.table1[this.mainNibPicker]));
            w13.TopAttach = ((uint)(4));
            w13.BottomAttach = ((uint)(5));
            w13.LeftAttach = ((uint)(1));
            w13.RightAttach = ((uint)(2));
            w13.YOptions = ((Gtk.AttachOptions)(0));
            this.alignment1.Add(this.table1);
            this.vbox1.Add(this.alignment1);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox1[this.alignment1]));
            w15.Position = 1;
            w15.Expand = false;
            w15.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}
