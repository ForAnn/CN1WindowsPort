// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.share {
public class EmailShare_21_22: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.List _fval_2contacts;

public global::com.codename1.share.EmailShare_21 _fthis_21;

public void @this(global::com.codename1.share.EmailShare_21 n1, global::com.codename1.ui.List n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare$1$2: void <init>(com.codename1.share.EmailShare$1, com.codename1.ui.List)]
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
    ((global::com.codename1.share.EmailShare_21_22) _r0_o)._fthis_21 = (global::com.codename1.share.EmailShare_21) _r1_o;
    ((global::com.codename1.share.EmailShare_21_22) _r0_o)._fval_2contacts = (global::com.codename1.ui.List) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare$1$2: void <init>(com.codename1.share.EmailShare$1, com.codename1.ui.List)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare$1$2: void run()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r1_o = ((global::com.codename1.share.EmailShare_21_22) _r4_o)._fval_2contacts;
    _r2_o = new global::com.codename1.share.EmailShare_21_22_21();
    ((global::com.codename1.share.EmailShare_21_22_21) _r2_o).@this((global::com.codename1.share.EmailShare_21_22) _r4_o);
    ((global::com.codename1.ui.List) _r1_o).addActionListener((global::com.codename1.ui.events.ActionListener) _r2_o);
    _r1_o = ((global::com.codename1.share.EmailShare_21_22) _r4_o)._fthis_21;
    _r1_o = ((global::com.codename1.share.EmailShare_21) _r1_o)._fval_2contactsForm;
    // Value=Center
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r3_o = ((global::com.codename1.share.EmailShare_21_22) _r4_o)._fval_2contacts;
    ((global::com.codename1.ui.Form) _r1_o).addComponent((global::java.lang.Object) _r2_o, (global::com.codename1.ui.Component) _r3_o);
    _r0_o = new global::com.codename1.share.EmailShare_21_22_22();
    // Value=Back
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)66)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107))}));
    ((global::com.codename1.share.EmailShare_21_22_22) _r0_o).@this((global::com.codename1.share.EmailShare_21_22) _r4_o, (global::java.lang.String) _r1_o);
    _r1_o = ((global::com.codename1.share.EmailShare_21_22) _r4_o)._fthis_21;
    _r1_o = ((global::com.codename1.share.EmailShare_21) _r1_o)._fval_2contactsForm;
    ((global::com.codename1.ui.Form) _r1_o).addCommand((global::com.codename1.ui.Command) _r0_o);
    _r1_o = ((global::com.codename1.share.EmailShare_21_22) _r4_o)._fthis_21;
    _r1_o = ((global::com.codename1.share.EmailShare_21) _r1_o)._fval_2contactsForm;
    ((global::com.codename1.ui.Form) _r1_o).setBackCommand((global::com.codename1.ui.Command) _r0_o);
    _r1_o = ((global::com.codename1.share.EmailShare_21_22) _r4_o)._fthis_21;
    _r1_o = ((global::com.codename1.share.EmailShare_21) _r1_o)._fval_2contactsForm;
    ((global::com.codename1.ui.Form) _r1_o).revalidate();
    return;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare$1$2: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare$1$2]
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare$1$2]

} // end of class: EmailShare_21_22

} // end of namespace: com.codename1.share
