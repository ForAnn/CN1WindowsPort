// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.aelfred2 {
public class SAXDriver_2Attribute: global::java.lang.Object {
public global::java.lang.String _fname;

public global::java.lang.String _fvalue;

public global::java.lang.String _fnameSpace;

public global::java.lang.String _flocalName;

public bool _fspecified;

public void @this(global::java.lang.String n1, global::java.lang.String n2, bool n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.SAXDriver$Attribute: void <init>(java.lang.String, java.lang.String, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3 ? 1 : 0;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::gnu.xml.aelfred2.SAXDriver_2Attribute) _r1_o)._fname = (global::java.lang.String) _r2_o;
    ((global::gnu.xml.aelfred2.SAXDriver_2Attribute) _r1_o)._fvalue = (global::java.lang.String) _r3_o;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    ((global::gnu.xml.aelfred2.SAXDriver_2Attribute) _r1_o)._fnameSpace = (global::java.lang.String) _r0_o;
    ((global::gnu.xml.aelfred2.SAXDriver_2Attribute) _r1_o)._fspecified = 0!=_r4.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.SAXDriver$Attribute: void <init>(java.lang.String, java.lang.String, boolean)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.SAXDriver$Attribute]
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.SAXDriver$Attribute]

} // end of class: SAXDriver_2Attribute

} // end of namespace: gnu.xml.aelfred2
