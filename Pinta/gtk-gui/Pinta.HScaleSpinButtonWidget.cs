//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pinta {
    
    
    public partial class HScaleSpinButtonWidget {
        
        private Gtk.VBox vbox;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label;
        
        private Gtk.HSeparator hseparator;
        
        private Gtk.HBox hbox2;
        
        private Gtk.HScale hscale;
        
        private Gtk.SpinButton spin;
        
        private Gtk.Button button;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Pinta.HScaleSpinButtonWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "Pinta.HScaleSpinButtonWidget";
            // Container child Pinta.HScaleSpinButtonWidget.Gtk.Container+ContainerChild
            this.vbox = new Gtk.VBox();
            this.vbox.Name = "vbox";
            this.vbox.Spacing = 6;
            // Container child vbox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label = new Gtk.Label();
            this.label.Name = "label";
            this.label.LabelProp = Mono.Unix.Catalog.GetString("label1");
            this.hbox1.Add(this.label);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox1[this.label]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.hseparator = new Gtk.HSeparator();
            this.hseparator.Name = "hseparator";
            this.hbox1.Add(this.hseparator);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.hseparator]));
            w2.Position = 1;
            this.vbox.Add(this.hbox1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox[this.hbox1]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.hscale = new Gtk.HScale(null);
            this.hscale.CanFocus = true;
            this.hscale.Name = "hscale";
            this.hscale.Adjustment.Upper = 100;
            this.hscale.Adjustment.PageIncrement = 10;
            this.hscale.Adjustment.StepIncrement = 1;
            this.hscale.DrawValue = false;
            this.hscale.Digits = 0;
            this.hscale.ValuePos = ((Gtk.PositionType)(2));
            this.hbox2.Add(this.hscale);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox2[this.hscale]));
            w4.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.spin = new Gtk.SpinButton(0, 100, 1);
            this.spin.CanFocus = true;
            this.spin.Name = "spin";
            this.spin.Adjustment.PageIncrement = 10;
            this.spin.ClimbRate = 1;
            this.spin.Numeric = true;
            this.hbox2.Add(this.spin);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox2[this.spin]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.button = new Gtk.Button();
            this.button.CanFocus = true;
            this.button.Name = "button";
            this.button.UseUnderline = true;
            // Container child button.Gtk.Container+ContainerChild
            Gtk.Alignment w6 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w7 = new Gtk.HBox();
            w7.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w8 = new Gtk.Image();
            w8.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-go-back", Gtk.IconSize.Menu, 16);
            w7.Add(w8);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w10 = new Gtk.Label();
            w7.Add(w10);
            w6.Add(w7);
            this.button.Add(w6);
            this.hbox2.Add(this.button);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox2[this.button]));
            w14.Position = 2;
            w14.Expand = false;
            w14.Fill = false;
            this.vbox.Add(this.hbox2);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox[this.hbox2]));
            w15.Position = 1;
            w15.Expand = false;
            w15.Fill = false;
            this.Add(this.vbox);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}
