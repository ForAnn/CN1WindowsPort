// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public class DTDAttributeTypeInfo: global::java.lang.Object,global::org.w3c.dom.TypeInfo {
public global::java.lang.String _felementName;

public global::java.lang.String _fname;

public global::java.lang.String _ftype;

public global::java.lang.String _fmode;

public global::java.lang.String _fvalue;

public static int _fDERIVATION_1RESTRICTION = org.w3c.dom._iTypeInfo._fDERIVATION_1RESTRICTION;

public static int _fDERIVATION_1EXTENSION = org.w3c.dom._iTypeInfo._fDERIVATION_1EXTENSION;

public static int _fDERIVATION_1UNION = org.w3c.dom._iTypeInfo._fDERIVATION_1UNION;

public static int _fDERIVATION_1LIST = org.w3c.dom._iTypeInfo._fDERIVATION_1LIST;

public void @this(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4, global::java.lang.String n5){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DTDAttributeTypeInfo: void <init>(java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    _r4_o = n4;
    _r5_o = n5;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::gnu.xml.dom.DTDAttributeTypeInfo) _r0_o)._felementName = (global::java.lang.String) _r1_o;
    ((global::gnu.xml.dom.DTDAttributeTypeInfo) _r0_o)._fname = (global::java.lang.String) _r2_o;
    ((global::gnu.xml.dom.DTDAttributeTypeInfo) _r0_o)._ftype = (global::java.lang.String) _r3_o;
    ((global::gnu.xml.dom.DTDAttributeTypeInfo) _r0_o)._fmode = (global::java.lang.String) _r4_o;
    ((global::gnu.xml.dom.DTDAttributeTypeInfo) _r0_o)._fvalue = (global::java.lang.String) _r5_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DTDAttributeTypeInfo: void <init>(java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
}

public virtual global::System.Object getTypeName(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DTDAttributeTypeInfo: java.lang.String getTypeName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DTDAttributeTypeInfo) _r1_o)._ftype;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DTDAttributeTypeInfo: java.lang.String getTypeName()]
}

public virtual global::System.Object getTypeNamespace(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DTDAttributeTypeInfo: java.lang.String getTypeNamespace()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=http://www.w3.org/TR/REC-xml
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 51)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DTDAttributeTypeInfo: java.lang.String getTypeNamespace()]
}

public virtual bool isDerivedFrom(global::java.lang.String n1, global::java.lang.String n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DTDAttributeTypeInfo: boolean isDerivedFrom(java.lang.String, java.lang.String, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.DTDAttributeTypeInfo: boolean isDerivedFrom(java.lang.String, java.lang.String, int)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DTDAttributeTypeInfo]
//XMLVM_END_WRAPPER[gnu.xml.dom.DTDAttributeTypeInfo]

} // end of class: DTDAttributeTypeInfo

} // end of namespace: gnu.xml.dom
