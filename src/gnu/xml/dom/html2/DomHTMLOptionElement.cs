// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom.html2 {
public class DomHTMLOptionElement: global::gnu.xml.dom.html2.DomHTMLElement,global::org.w3c.dom.html2.HTMLOptionElement {
public global::java.lang.Boolean _fselected;

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
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void <init>(gnu.xml.dom.html2.DomHTMLDocument, java.lang.String, java.lang.String)]
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
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void <init>(gnu.xml.dom.html2.DomHTMLDocument, java.lang.String, java.lang.String)]
}

public virtual global::System.Object getForm(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: org.w3c.dom.html2.HTMLFormElement getForm()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=form
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109))}));
    _r1_o = ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).getParentElement((global::java.lang.String) _r0_o);
    _r1_o = _r1_o;
    return (global::org.w3c.dom.html2.HTMLFormElement) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: org.w3c.dom.html2.HTMLFormElement getForm()]
}

public virtual bool getDefaultSelected(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: boolean getDefaultSelected()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=selected
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).getBooleanHTMLAttribute((global::java.lang.String) _r0_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: boolean getDefaultSelected()]
}

public virtual void setDefaultSelected(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void setDefaultSelected(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    // Value=selected
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).setBooleanHTMLAttribute((global::java.lang.String) _r0_o, 0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void setDefaultSelected(boolean)]
}

public virtual global::System.Object getText(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: java.lang.String getText()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).getTextContent();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: java.lang.String getText()]
}

public override int getIndex(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: int getIndex()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = base.getIndex();
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: int getIndex()]
}

public virtual bool getDisabled(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: boolean getDisabled()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=disabled
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).getBooleanHTMLAttribute((global::java.lang.String) _r0_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: boolean getDisabled()]
}

public virtual void setDisabled(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void setDisabled(boolean)]
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
    ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).setBooleanHTMLAttribute((global::java.lang.String) _r0_o, 0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void setDisabled(boolean)]
}

public virtual global::System.Object getLabel(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: java.lang.String getLabel()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=label
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: java.lang.String getLabel()]
}

public virtual void setLabel(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void setLabel(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=label
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108))}));
    ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void setLabel(java.lang.String)]
}

public virtual bool getSelected(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: boolean getSelected()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o)._fselected;
    if (_r0_o != null) goto label14;
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).getDefaultSelected() ? 1 : 0;
    _r0_o = global::java.lang.Boolean.valueOf(0!=_r0.i);
    ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o)._fselected = (global::java.lang.Boolean) _r0_o;
    label14:;
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o)._fselected;
    _r0.i = ((global::java.lang.Boolean) _r0_o).booleanValue() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: boolean getSelected()]
}

public virtual void setSelected(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void setSelected(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    _r0_o = global::java.lang.Boolean.valueOf(0!=_r2.i);
    ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o)._fselected = (global::java.lang.Boolean) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void setSelected(boolean)]
}

public virtual global::System.Object getValue(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: java.lang.String getValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=value
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: java.lang.String getValue()]
}

public virtual void setValue(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void setValue(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=value
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    ((global::gnu.xml.dom.html2.DomHTMLOptionElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement: void setValue(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement]
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLOptionElement]

} // end of class: DomHTMLOptionElement

} // end of namespace: gnu.xml.dom.html2
