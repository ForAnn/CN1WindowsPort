// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.share {
public class EmailShare: global::com.codename1.share.ShareService {
public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare: void <init>()]
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
    // Value=Email
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)69)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108))}));
    _r1_o = global::com.codename1.ui.util.Resources.getSystemResource();
    // Value=mail.png
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    _r1_o = ((global::com.codename1.ui.util.Resources) _r1_o).getImage((global::java.lang.String) _r2_o);
    ((global::com.codename1.share.ShareService) _r3_o).@this((global::java.lang.String) _r0_o, (global::com.codename1.ui.Image) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare: void <init>()]
}

public override void share(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare: void share(java.lang.String, java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = this;
    _r9_o = n1;
    _r10_o = n2;
    _r11_o = n3;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r2_o = ((global::com.codename1.ui.Display) _r0_o).getCurrent();
    _r4_o = new global::com.codename1.ui.Form();
    // Value=Contacts
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 115))}));
    ((global::com.codename1.ui.Form) _r4_o).@this((global::java.lang.String) _r0_o);
    _r0_o = new global::com.codename1.ui.layouts.BorderLayout();
    ((global::com.codename1.ui.layouts.BorderLayout) _r0_o).@this();
    ((global::com.codename1.ui.Form) _r4_o).setLayout((global::com.codename1.ui.layouts.Layout) _r0_o);
    _r0.i = 0;
    ((global::com.codename1.ui.Form) _r4_o).setScrollable(0!=_r0.i);
    // Value=Center
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r1_o = new global::com.codename1.ui.Label();
    // Value=Please wait...
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)80)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 46))}));
    ((global::com.codename1.ui.Label) _r1_o).@this((global::java.lang.String) _r3_o);
    ((global::com.codename1.ui.Form) _r4_o).addComponent((global::java.lang.Object) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    ((global::com.codename1.ui.Form) _r4_o).show();
    _r7_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = new global::com.codename1.share.EmailShare_21();
    _r1_o = _r8_o;
    _r3_o = _r10_o;
    _r5_o = _r9_o;
    _r6_o = _r11_o;
    ((global::com.codename1.share.EmailShare_21) _r0_o).@this((global::com.codename1.share.EmailShare) _r1_o, (global::com.codename1.ui.Form) _r2_o, (global::java.lang.String) _r3_o, (global::com.codename1.ui.Form) _r4_o, (global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    // Value=Email Thread
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)69)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100))}));
    _r0_o = ((global::com.codename1.ui.Display) _r7_o).startThread((global::java.lang.Runnable) _r0_o, (global::java.lang.String) _r1_o);
    ((global::java.lang.Thread) _r0_o).start();
    return;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare: void share(java.lang.String, java.lang.String, java.lang.String)]
}

public override void share(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare: void share(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    ((global::com.codename1.share.EmailShare) _r1_o).share((global::java.lang.String) _r2_o, (global::java.lang.String) _r0_o, (global::java.lang.String) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare: void share(java.lang.String)]
}

private global::System.Object createRendererMultiButton(){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare: com.codename1.components.MultiButton createRendererMultiButton()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::com.codename1.components.MultiButton();
    ((global::com.codename1.components.MultiButton) _r0_o).@this();
    // Value=icon
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::com.codename1.components.MultiButton) _r0_o).setIconName((global::java.lang.String) _r1_o);
    // Value=fname
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.components.MultiButton) _r0_o).setNameLine1((global::java.lang.String) _r1_o);
    // Value=phone
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.components.MultiButton) _r0_o).setNameLine2((global::java.lang.String) _r1_o);
    // Value=Label
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)76)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108))}));
    ((global::com.codename1.components.MultiButton) _r0_o).setUIID((global::java.lang.String) _r1_o);
    return (global::com.codename1.components.MultiButton) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare: com.codename1.components.MultiButton createRendererMultiButton()]
}

private global::System.Object createListRenderer(){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare: com.codename1.ui.list.ListCellRenderer createListRenderer()]
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
    _r0_o = ((global::com.codename1.share.EmailShare) _r3_o).createRendererMultiButton();
    _r1_o = ((global::com.codename1.share.EmailShare) _r3_o).createRendererMultiButton();
    _r2_o = new global::com.codename1.ui.list.GenericListCellRenderer();
    ((global::com.codename1.ui.list.GenericListCellRenderer) _r2_o).@this((global::com.codename1.ui.Component) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    return (global::com.codename1.ui.list.ListCellRenderer) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare: com.codename1.ui.list.ListCellRenderer createListRenderer()]
}

public override bool canShareImage(){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare: boolean canShareImage()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare: boolean canShareImage()]
}

public static global::System.Object access_2000(global::com.codename1.share.EmailShare n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare: com.codename1.ui.list.ListCellRenderer access$000(com.codename1.share.EmailShare)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r0_o = ((global::com.codename1.share.EmailShare) _r1_o).createListRenderer();
    return (global::com.codename1.ui.list.ListCellRenderer) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare: com.codename1.ui.list.ListCellRenderer access$000(com.codename1.share.EmailShare)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare]
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare]

} // end of class: EmailShare

} // end of namespace: com.codename1.share
