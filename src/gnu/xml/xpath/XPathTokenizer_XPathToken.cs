// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.xpath {
public class XPathTokenizer_2XPathToken: global::java.lang.Object {
public int _ftype;

public global::java.lang.String _fval;

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.XPathTokenizer$XPathToken: void <init>(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = null;
    ((global::gnu.xml.xpath.XPathTokenizer_2XPathToken) _r1_o).@this((int) _r2.i, (global::java.lang.String) _r0_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.XPathTokenizer$XPathToken: void <init>(int)]
}

public void @this(int n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.XPathTokenizer$XPathToken: void <init>(int, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    _r2_o = n2;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::gnu.xml.xpath.XPathTokenizer_2XPathToken) _r0_o)._ftype = _r1.i;
    ((global::gnu.xml.xpath.XPathTokenizer_2XPathToken) _r0_o)._fval = (global::java.lang.String) _r2_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.XPathTokenizer$XPathToken: void <init>(int, java.lang.String)]
}

public virtual global::System.Object getText(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.XPathTokenizer$XPathToken: java.lang.String getText()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.xpath.XPathTokenizer_2XPathToken) _r1_o)._fval;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.XPathTokenizer$XPathToken: java.lang.String getText()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.XPathTokenizer$XPathToken: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.xpath.XPathTokenizer_2XPathToken) _r1_o)._fval;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.XPathTokenizer$XPathToken: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.XPathTokenizer$XPathToken]
//XMLVM_END_WRAPPER[gnu.xml.xpath.XPathTokenizer$XPathToken]

} // end of class: XPathTokenizer_2XPathToken

} // end of namespace: gnu.xml.xpath
