// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.components {
public class ShareButton: global::com.codename1.ui.Button,global::com.codename1.ui.events.ActionListener {
private global::java.lang.String _ftextToShare;

private global::java.lang.String _fimageToShare;

private global::java.lang.String _fimageMimeType;

private global::java.util.Vector _fshareServices;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    ((global::com.codename1.ui.Button) _r3_o).@this();
    _r1_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r1_o).@this();
    ((global::com.codename1.components.ShareButton) _r3_o)._fshareServices = (global::java.util.Vector) _r1_o;
    // Value=ShareButton
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::com.codename1.components.ShareButton) _r3_o).setUIID((global::java.lang.String) _r1_o);
    _r1_o = global::com.codename1.ui.util.Resources.getSystemResource();
    // Value=share.png
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    _r0_o = ((global::com.codename1.ui.util.Resources) _r1_o).getImage((global::java.lang.String) _r2_o);
    ((global::com.codename1.components.ShareButton) _r3_o).setIcon((global::com.codename1.ui.Image) _r0_o);
    ((global::com.codename1.components.ShareButton) _r3_o).addActionListener((global::com.codename1.ui.events.ActionListener) _r3_o);
    _r1_o = ((global::com.codename1.components.ShareButton) _r3_o)._fshareServices;
    _r2_o = new global::com.codename1.share.SMSShare();
    ((global::com.codename1.share.SMSShare) _r2_o).@this();
    ((global::java.util.Vector) _r1_o).addElement((global::java.lang.Object) _r2_o);
    _r1_o = ((global::com.codename1.components.ShareButton) _r3_o)._fshareServices;
    _r2_o = new global::com.codename1.share.EmailShare();
    ((global::com.codename1.share.EmailShare) _r2_o).@this();
    ((global::java.util.Vector) _r1_o).addElement((global::java.lang.Object) _r2_o);
    _r1_o = ((global::com.codename1.components.ShareButton) _r3_o)._fshareServices;
    _r2_o = new global::com.codename1.share.FacebookShare();
    ((global::com.codename1.share.FacebookShare) _r2_o).@this();
    ((global::java.util.Vector) _r1_o).addElement((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: void <init>()]
}

public virtual void setTextToShare(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: void setTextToShare(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.components.ShareButton) _r0_o)._ftextToShare = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: void setTextToShare(java.lang.String)]
}

public virtual global::System.Object getTextToShare(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: java.lang.String getTextToShare()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.ShareButton) _r1_o)._ftextToShare;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: java.lang.String getTextToShare()]
}

public virtual void setImageToShare(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: void setImageToShare(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.components.ShareButton) _r0_o)._fimageToShare = (global::java.lang.String) _r1_o;
    ((global::com.codename1.components.ShareButton) _r0_o)._fimageMimeType = (global::java.lang.String) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: void setImageToShare(java.lang.String, java.lang.String)]
}

public virtual global::System.Object getImagePathToShare(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: java.lang.String getImagePathToShare()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.ShareButton) _r1_o)._fimageToShare;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: java.lang.String getImagePathToShare()]
}

public virtual void addShareService(global::com.codename1.share.ShareService n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: void addShareService(com.codename1.share.ShareService)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.ShareButton) _r1_o)._fshareServices;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: void addShareService(com.codename1.share.ShareService)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r14_o = this;
    _r15_o = n1;
    _r7.i = 1;
    _r5_o = global::com.codename1.ui.Display.getInstance();
    _r5.i = ((global::com.codename1.ui.Display) _r5_o).isNativeShareSupported() ? 1 : 0;
    if (_r5.i == 0) goto label46;
    _r5_o = global::com.codename1.ui.Display.getInstance();
    _r6_o = ((global::com.codename1.components.ShareButton) _r14_o)._ftextToShare;
    _r7_o = ((global::com.codename1.components.ShareButton) _r14_o)._fimageToShare;
    _r8_o = ((global::com.codename1.components.ShareButton) _r14_o)._fimageMimeType;
    _r9_o = new global::com.codename1.ui.geom.Rectangle();
    _r10.i = ((global::com.codename1.components.ShareButton) _r14_o).getAbsoluteX();
    _r11.i = ((global::com.codename1.components.ShareButton) _r14_o).getAbsoluteY();
    _r12.i = ((global::com.codename1.components.ShareButton) _r14_o).getWidth();
    _r13.i = ((global::com.codename1.components.ShareButton) _r14_o).getHeight();
    ((global::com.codename1.ui.geom.Rectangle) _r9_o).@this((int) _r10.i, (int) _r11.i, (int) _r12.i, (int) _r13.i);
    ((global::com.codename1.ui.Display) _r5_o).share((global::java.lang.String) _r6_o, (global::java.lang.String) _r7_o, (global::java.lang.String) _r8_o, (global::com.codename1.ui.geom.Rectangle) _r9_o);
    label45:;
    return;
    label46:;
    _r5_o = ((global::com.codename1.components.ShareButton) _r14_o)._fimageToShare;
    if (_r5_o == null) goto label84;
    _r4_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r4_o).@this();
    _r1.i = 0;
    label56:;
    _r5_o = ((global::com.codename1.components.ShareButton) _r14_o)._fshareServices;
    _r5.i = ((global::java.util.Vector) _r5_o).size();
    if (_r1.i >= _r5.i) goto label86;
    _r5_o = ((global::com.codename1.components.ShareButton) _r14_o)._fshareServices;
    _r3_o = ((global::java.util.Vector) _r5_o).elementAt((int) _r1.i);
    _r3_o = _r3_o;
    _r5.i = ((global::com.codename1.share.ShareService) _r3_o).canShareImage() ? 1 : 0;
    if (_r5.i == 0) goto label81;
    ((global::java.util.Vector) _r4_o).add((global::java.lang.Object) _r3_o);
    label81:;
    _r1.i = _r1.i + 1;
    goto label56;
    label84:;
    _r4_o = ((global::com.codename1.components.ShareButton) _r14_o)._fshareServices;
    label86:;
    _r1.i = 0;
    label87:;
    _r5.i = ((global::java.util.Vector) _r4_o).size();
    if (_r1.i >= _r5.i) goto label121;
    _r3_o = ((global::java.util.Vector) _r4_o).elementAt((int) _r1.i);
    _r3_o = _r3_o;
    _r5_o = ((global::com.codename1.components.ShareButton) _r14_o)._ftextToShare;
    ((global::com.codename1.share.ShareService) _r3_o).setMessage((global::java.lang.String) _r5_o);
    _r5_o = ((global::com.codename1.components.ShareButton) _r14_o)._fimageToShare;
    _r6_o = ((global::com.codename1.components.ShareButton) _r14_o)._fimageMimeType;
    ((global::com.codename1.share.ShareService) _r3_o).setImage((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    _r5_o = ((global::com.codename1.components.ShareButton) _r14_o).getComponentForm();
    ((global::com.codename1.share.ShareService) _r3_o).setOriginalForm((global::com.codename1.ui.Form) _r5_o);
    _r1.i = _r1.i + 1;
    goto label87;
    label121:;
    _r2_o = new global::com.codename1.ui.List();
    ((global::com.codename1.ui.List) _r2_o).@this((global::java.util.Vector) _r4_o);
    ((global::com.codename1.ui.List) _r2_o).setCommandList(0!=_r7.i);
    _r0_o = new global::com.codename1.ui.Dialog();
    // Value=Share
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.ui.Dialog) _r0_o).@this((global::java.lang.String) _r5_o);
    _r5_o = new global::com.codename1.ui.layouts.BorderLayout();
    ((global::com.codename1.ui.layouts.BorderLayout) _r5_o).@this();
    ((global::com.codename1.ui.Dialog) _r0_o).setLayout((global::com.codename1.ui.layouts.Layout) _r5_o);
    // Value=Center
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::com.codename1.ui.Dialog) _r0_o).addComponent((global::java.lang.Object) _r5_o, (global::com.codename1.ui.Component) _r2_o);
    _r5_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r7.i]);
    _r6.i = 0;
    _r7_o = new global::com.codename1.ui.Command();
    // Value=Cancel
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108))}));
    ((global::com.codename1.ui.Command) _r7_o).@this((global::java.lang.String) _r8_o);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r5_o)[_r6.i] = _r7_o;
    ((global::com.codename1.ui.Dialog) _r0_o).placeButtonCommands((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r5_o);
    _r5_o = new global::com.codename1.components.ShareButton_21();
    ((global::com.codename1.components.ShareButton_21) _r5_o).@this((global::com.codename1.components.ShareButton) _r14_o, (global::com.codename1.ui.Dialog) _r0_o);
    ((global::com.codename1.ui.List) _r2_o).addActionListener((global::com.codename1.ui.events.ActionListener) _r5_o);
    ((global::com.codename1.ui.Dialog) _r0_o).show();
    goto label45;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

public override global::System.Object getPropertyNames(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: java.lang.String[] getPropertyNames()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    // Value=textToShare
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: java.lang.String[] getPropertyNames()]
}

public override global::System.Object getPropertyTypes(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: java.lang.Class[] getPropertyTypes()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.String));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: java.lang.Class[] getPropertyTypes()]
}

public override global::System.Object getPropertyValue(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: java.lang.Object getPropertyValue(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=textToShare
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label13;
    _r0_o = ((global::com.codename1.components.ShareButton) _r1_o).getTextToShare();
    label12:;
    return (global::java.lang.Object) _r0_o;
    label13:;
    _r0_o = null;
    goto label12;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: java.lang.Object getPropertyValue(java.lang.String)]
}

public override global::System.Object setPropertyValue(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton: java.lang.String setPropertyValue(java.lang.String, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    // Value=textToShare
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r3_o = _r3_o;
    ((global::com.codename1.components.ShareButton) _r1_o).setTextToShare((global::java.lang.String) _r3_o);
    _r0_o = null;
    label14:;
    return (global::java.lang.String) _r0_o;
    label15:;
    _r0_o = base.setPropertyValue((global::java.lang.String) _r2_o, (global::java.lang.Object) _r3_o);
    goto label14;
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton: java.lang.String setPropertyValue(java.lang.String, java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.components.ShareButton]
//XMLVM_END_WRAPPER[com.codename1.components.ShareButton]

} // end of class: ShareButton

} // end of namespace: com.codename1.components
