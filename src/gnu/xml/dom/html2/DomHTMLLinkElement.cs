// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom.html2 {
public class DomHTMLLinkElement: global::gnu.xml.dom.html2.DomHTMLElement,global::org.w3c.dom.html2.HTMLLinkElement {
public static short _fELEMENT_1NODE = org.w3c.dom._iNode._fELEMENT_1NODE;

public static short _fATTRIBUTE_1NODE = org.w3c.dom._iNode._fATTRIBUTE_1NODE;

public static short _fTEXT_1NODE = org.w3c.dom._iNode._fTEXT_1NODE;

public static short _fCDATA_1SECTION_1NODE = org.w3c.dom._iNode._fCDATA_1SECTION_1NODE;

public static short _fENTITY_1REFERENCE_1NODE = org.w3c.dom._iNode._fENTITY_1REFERENCE_1NODE;

public static short _fENTITY_1NODE = org.w3c.dom._iNode._fENTITY_1NODE;

public static short _fPROCESSING_1INSTRUCTION_1NODE = org.w3c.dom._iNode._fPROCESSING_1INSTRUCTION_1NODE;

public static short _fCOMMENT_1NODE = org.w3c.dom._iNode._fCOMMENT_1NODE;

public static short _fDOCUMENT_1NODE = org.w3c.dom._iNode._fDOCUMENT_1NODE;

public static short _fDOCUMENT_1TYPE_1NODE = org.w3c.dom._iNode._fDOCUMENT_1TYPE_1NODE;

public static short _fDOCUMENT_1FRAGMENT_1NODE = org.w3c.dom._iNode._fDOCUMENT_1FRAGMENT_1NODE;

public static short _fNOTATION_1NODE = org.w3c.dom._iNode._fNOTATION_1NODE;

public static short _fDOCUMENT_1POSITION_1DISCONNECTED = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1DISCONNECTED;

public static short _fDOCUMENT_1POSITION_1PRECEDING = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1PRECEDING;

public static short _fDOCUMENT_1POSITION_1FOLLOWING = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1FOLLOWING;

public static short _fDOCUMENT_1POSITION_1CONTAINS = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1CONTAINS;

public static short _fDOCUMENT_1POSITION_1CONTAINED_1BY = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1CONTAINED_1BY;

public static short _fDOCUMENT_1POSITION_1IMPLEMENTATION_1SPECIFIC = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1IMPLEMENTATION_1SPECIFIC;

public void @this(global::gnu.xml.dom.html2.DomHTMLDocument n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void <init>(gnu.xml.dom.html2.DomHTMLDocument, java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::gnu.xml.dom.html2.DomHTMLElement) _r0_o).@this((global::gnu.xml.dom.html2.DomHTMLDocument) _r1_o, (global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void <init>(gnu.xml.dom.html2.DomHTMLDocument, java.lang.String, java.lang.String)]
}

public virtual bool getDisabled(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: boolean getDisabled()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=disabled
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).getBooleanHTMLAttribute((global::java.lang.String) _r0_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: boolean getDisabled()]
}

public virtual void setDisabled(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setDisabled(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    // Value=disabled
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).setBooleanHTMLAttribute((global::java.lang.String) _r0_o, 0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setDisabled(boolean)]
}

public virtual global::System.Object getCharset(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getCharset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=charset
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getCharset()]
}

public virtual void setCharset(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setCharset(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=charset
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116))}));
    ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setCharset(java.lang.String)]
}

public virtual global::System.Object getHref(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getHref()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=href
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getHref()]
}

public virtual void setHref(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setHref(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=href
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102))}));
    ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setHref(java.lang.String)]
}

public virtual global::System.Object getHreflang(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getHreflang()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=hreflang
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getHreflang()]
}

public virtual void setHreflang(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setHreflang(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=hreflang
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setHreflang(java.lang.String)]
}

public virtual global::System.Object getMedia(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getMedia()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=media
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getMedia()]
}

public virtual void setMedia(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setMedia(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=media
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97))}));
    ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setMedia(java.lang.String)]
}

public virtual global::System.Object getRel(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getRel()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=rel
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getRel()]
}

public virtual void setRel(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setRel(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=rel
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108))}));
    ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setRel(java.lang.String)]
}

public virtual global::System.Object getRev(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getRev()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=rev
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 118))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getRev()]
}

public virtual void setRev(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setRev(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=rev
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 118))}));
    ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setRev(java.lang.String)]
}

public virtual global::System.Object getTarget(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getTarget()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=target
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getTarget()]
}

public virtual void setTarget(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setTarget(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=target
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116))}));
    ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setTarget(java.lang.String)]
}

public virtual global::System.Object getType(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=type
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: java.lang.String getType()]
}

public virtual void setType(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setType(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=type
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    ((global::gnu.xml.dom.html2.DomHTMLLinkElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement: void setType(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement]
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLLinkElement]

} // end of class: DomHTMLLinkElement

} // end of namespace: gnu.xml.dom.html2
