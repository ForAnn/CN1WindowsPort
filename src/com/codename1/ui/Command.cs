// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class Command: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
private bool _fdisposesDialog;

private global::com.codename1.ui.Image _ficon;

private global::com.codename1.ui.Image _fpressedIcon;

private global::com.codename1.ui.Image _frolloverIcon;

private global::com.codename1.ui.Image _fdisabledIcon;

private global::java.lang.String _fcommand;

private bool _fenabled;

private int _fcommandId;

private global::java.util.HashMap _fclientProperties;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 1;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::com.codename1.ui.Command) _r1_o)._fdisposesDialog = 0!=_r0.i;
    ((global::com.codename1.ui.Command) _r1_o)._fenabled = 0!=_r0.i;
    ((global::com.codename1.ui.Command) _r1_o)._fcommand = (global::java.lang.String) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void <init>(java.lang.String)]
}

public void @this(global::java.lang.String n1, global::com.codename1.ui.Image n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void <init>(java.lang.String, com.codename1.ui.Image)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0.i = 1;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::com.codename1.ui.Command) _r1_o)._fdisposesDialog = 0!=_r0.i;
    ((global::com.codename1.ui.Command) _r1_o)._fenabled = 0!=_r0.i;
    ((global::com.codename1.ui.Command) _r1_o)._fcommand = (global::java.lang.String) _r2_o;
    ((global::com.codename1.ui.Command) _r1_o)._ficon = (global::com.codename1.ui.Image) _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void <init>(java.lang.String, com.codename1.ui.Image)]
}

public void @this(global::java.lang.String n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void <init>(java.lang.String, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r0.i = 1;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::com.codename1.ui.Command) _r1_o)._fdisposesDialog = 0!=_r0.i;
    ((global::com.codename1.ui.Command) _r1_o)._fenabled = 0!=_r0.i;
    ((global::com.codename1.ui.Command) _r1_o)._fcommand = (global::java.lang.String) _r2_o;
    ((global::com.codename1.ui.Command) _r1_o)._fcommandId = _r3.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void <init>(java.lang.String, int)]
}

public void @this(global::java.lang.String n1, global::com.codename1.ui.Image n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void <init>(java.lang.String, com.codename1.ui.Image, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    _r0.i = 1;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::com.codename1.ui.Command) _r1_o)._fdisposesDialog = 0!=_r0.i;
    ((global::com.codename1.ui.Command) _r1_o)._fenabled = 0!=_r0.i;
    ((global::com.codename1.ui.Command) _r1_o)._fcommand = (global::java.lang.String) _r2_o;
    ((global::com.codename1.ui.Command) _r1_o)._fcommandId = _r4.i;
    ((global::com.codename1.ui.Command) _r1_o)._ficon = (global::com.codename1.ui.Image) _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void <init>(java.lang.String, com.codename1.ui.Image, int)]
}

public virtual int getId(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: int getId()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.Command) _r1_o)._fcommandId;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: int getId()]
}

public virtual global::System.Object getCommandName(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: java.lang.String getCommandName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o)._fcommand;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: java.lang.String getCommandName()]
}

public virtual void setCommandName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void setCommandName(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.Command) _r0_o)._fcommand = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void setCommandName(java.lang.String)]
}

public virtual global::System.Object getIcon(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: com.codename1.ui.Image getIcon()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o)._ficon;
    return (global::com.codename1.ui.Image) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: com.codename1.ui.Image getIcon()]
}

public virtual void setIcon(global::com.codename1.ui.Image n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void setIcon(com.codename1.ui.Image)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.Command) _r0_o)._ficon = (global::com.codename1.ui.Image) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void setIcon(com.codename1.ui.Image)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o).getCommandName();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: java.lang.String toString()]
}

public virtual global::System.Object getPressedIcon(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: com.codename1.ui.Image getPressedIcon()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o)._fpressedIcon;
    return (global::com.codename1.ui.Image) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: com.codename1.ui.Image getPressedIcon()]
}

public virtual global::System.Object getDisabledIcon(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: com.codename1.ui.Image getDisabledIcon()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o)._fdisabledIcon;
    return (global::com.codename1.ui.Image) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: com.codename1.ui.Image getDisabledIcon()]
}

public virtual global::System.Object getRolloverIcon(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: com.codename1.ui.Image getRolloverIcon()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o)._frolloverIcon;
    return (global::com.codename1.ui.Image) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: com.codename1.ui.Image getRolloverIcon()]
}

public virtual void setRolloverIcon(global::com.codename1.ui.Image n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void setRolloverIcon(com.codename1.ui.Image)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.Command) _r0_o)._frolloverIcon = (global::com.codename1.ui.Image) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void setRolloverIcon(com.codename1.ui.Image)]
}

public virtual void setPressedIcon(global::com.codename1.ui.Image n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void setPressedIcon(com.codename1.ui.Image)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.Command) _r0_o)._fpressedIcon = (global::com.codename1.ui.Image) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void setPressedIcon(com.codename1.ui.Image)]
}

public virtual void setDisabledIcon(global::com.codename1.ui.Image n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void setDisabledIcon(com.codename1.ui.Image)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.Command) _r0_o)._fdisabledIcon = (global::com.codename1.ui.Image) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void setDisabledIcon(com.codename1.ui.Image)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: boolean equals(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r4.i = 1;
    _r3.i = 0;
    _r1.i = ((_r6_o != null) && (_r6_o is global::com.codename1.ui.Command)) ? 1 : 0;
    if (_r1.i != 0) goto label8;
    _r1.i = _r3.i;
    label7:;
    return _r1.i!=0;
    label8:;
    _r0_o = _r6_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1_o = ((global::com.codename1.ui.Command) _r1_o)._fcommand;
    if (_r1_o != null) goto label82;
    if (_r6_o == null) goto label80;
    _r1_o = ((global::java.lang.Object) _r6_o).getClass();
    _r2_o = ((global::java.lang.Object) _r5_o).getClass();
    if (_r1_o != _r2_o) goto label80;
    _r1_o = ((global::com.codename1.ui.Command) _r5_o)._fcommand;
    if (_r1_o != null) goto label80;
    _r0_o = _r6_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1_o = ((global::com.codename1.ui.Command) _r1_o)._ficon;
    _r2_o = ((global::com.codename1.ui.Command) _r5_o)._ficon;
    if (_r1_o != _r2_o) goto label80;
    _r0_o = _r6_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1.i = ((global::com.codename1.ui.Command) _r1_o)._fcommandId;
    _r2.i = ((global::com.codename1.ui.Command) _r5_o)._fcommandId;
    if (_r1.i != _r2.i) goto label80;
    _r2_o = ((global::com.codename1.ui.Command) _r5_o)._fclientProperties;
    _r0_o = _r6_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1_o = ((global::com.codename1.ui.Command) _r1_o)._fclientProperties;
    if (_r2_o == _r1_o) goto label78;
    _r1_o = ((global::com.codename1.ui.Command) _r5_o)._fclientProperties;
    if (_r1_o == null) goto label80;
    _r1_o = ((global::com.codename1.ui.Command) _r5_o)._fclientProperties;
    _r6_o = _r6_o;
    _r2_o = ((global::com.codename1.ui.Command) _r6_o)._fclientProperties;
    _r1.i = ((global::java.util.HashMap) _r1_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r1.i == 0) goto label80;
    label78:;
    _r1.i = _r4.i;
    goto label7;
    label80:;
    _r1.i = _r3.i;
    goto label7;
    label82:;
    if (_r6_o == null) goto label157;
    _r1_o = ((global::java.lang.Object) _r6_o).getClass();
    _r2_o = ((global::java.lang.Object) _r5_o).getClass();
    if (_r1_o != _r2_o) goto label157;
    _r0_o = _r6_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1_o = ((global::com.codename1.ui.Command) _r1_o)._fcommand;
    _r2_o = ((global::com.codename1.ui.Command) _r5_o)._fcommand;
    _r1.i = ((global::java.lang.String) _r1_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r1.i == 0) goto label157;
    _r0_o = _r6_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1_o = ((global::com.codename1.ui.Command) _r1_o)._ficon;
    _r2_o = ((global::com.codename1.ui.Command) _r5_o)._ficon;
    if (_r1_o != _r2_o) goto label157;
    _r0_o = _r6_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1.i = ((global::com.codename1.ui.Command) _r1_o)._fcommandId;
    _r2.i = ((global::com.codename1.ui.Command) _r5_o)._fcommandId;
    if (_r1.i != _r2.i) goto label157;
    _r2_o = ((global::com.codename1.ui.Command) _r5_o)._fclientProperties;
    _r0_o = _r6_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1_o = ((global::com.codename1.ui.Command) _r1_o)._fclientProperties;
    if (_r2_o == _r1_o) goto label154;
    _r1_o = ((global::com.codename1.ui.Command) _r5_o)._fclientProperties;
    if (_r1_o == null) goto label157;
    _r1_o = ((global::com.codename1.ui.Command) _r5_o)._fclientProperties;
    _r6_o = _r6_o;
    _r2_o = ((global::com.codename1.ui.Command) _r6_o)._fclientProperties;
    _r1.i = ((global::java.util.HashMap) _r1_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r1.i == 0) goto label157;
    label154:;
    _r1.i = _r4.i;
    goto label7;
    label157:;
    _r1.i = _r3.i;
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.lang.Object) _r2_o).getClass();
    _r0.i = ((global::java.lang.Object) _r0_o).hashCode();
    _r1.i = ((global::com.codename1.ui.Command) _r2_o)._fcommandId;
    _r0.i = _r0.i + _r1.i;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: int hashCode()]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

public virtual void setDisposesDialog(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void setDisposesDialog(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.ui.Command) _r0_o)._fdisposesDialog = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void setDisposesDialog(boolean)]
}

public virtual bool isDisposesDialog(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: boolean isDisposesDialog()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.Command) _r1_o)._fdisposesDialog ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: boolean isDisposesDialog()]
}

public virtual bool isEnabled(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: boolean isEnabled()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.Command) _r1_o)._fenabled ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: boolean isEnabled()]
}

public virtual void setEnabled(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void setEnabled(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.ui.Command) _r0_o)._fenabled = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void setEnabled(boolean)]
}

public virtual global::System.Object getClientProperty(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: java.lang.Object getClientProperty(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o)._fclientProperties;
    if (_r0_o == null) goto label11;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o)._fclientProperties;
    _r0_o = ((global::java.util.HashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    label10:;
    return (global::java.lang.Object) _r0_o;
    label11:;
    _r0_o = null;
    goto label10;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: java.lang.Object getClientProperty(java.lang.String)]
}

public virtual void putClientProperty(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command: void putClientProperty(java.lang.String, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o)._fclientProperties;
    if (_r0_o != null) goto label11;
    _r0_o = new global::java.util.HashMap();
    ((global::java.util.HashMap) _r0_o).@this();
    ((global::com.codename1.ui.Command) _r1_o)._fclientProperties = (global::java.util.HashMap) _r0_o;
    label11:;
    if (_r3_o != null) goto label19;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o)._fclientProperties;
    ((global::java.util.HashMap) _r0_o).remove((global::java.lang.Object) _r2_o);
    label18:;
    return;
    label19:;
    _r0_o = ((global::com.codename1.ui.Command) _r1_o)._fclientProperties;
    ((global::java.util.HashMap) _r0_o).put((global::java.lang.Object) _r2_o, (global::java.lang.Object) _r3_o);
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.ui.Command: void putClientProperty(java.lang.String, java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Command]
//XMLVM_END_WRAPPER[com.codename1.ui.Command]

} // end of class: Command

} // end of namespace: com.codename1.ui
