// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.xpath {
public class LastFunction: global::gnu.xml.xpath.Expr {
public void @this(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.LastFunction: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::gnu.xml.xpath.Expr) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.LastFunction: void <init>()]
}

public override global::System.Object evaluate(global::org.w3c.dom.Node n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.LastFunction: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r6.i = n3;
    _r0_o = new global::java.lang.Double();
    _r1.d = (double) _r6.i;
    ((global::java.lang.Double) _r0_o).@this((double) _r1.d);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.LastFunction: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
}

public override global::System.Object clone(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.LastFunction: gnu.xml.xpath.Expr clone(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::gnu.xml.xpath.LastFunction();
    ((global::gnu.xml.xpath.LastFunction) _r0_o).@this();
    return (global::gnu.xml.xpath.Expr) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.LastFunction: gnu.xml.xpath.Expr clone(java.lang.Object)]
}

public override bool references(global::javax.xml.@namespace.QName n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.LastFunction: boolean references(javax.xml.namespace.QName)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.xpath.LastFunction: boolean references(javax.xml.namespace.QName)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.LastFunction: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=last()
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 40)), unchecked((char) unchecked((uint) 41))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.LastFunction: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.LastFunction]
//XMLVM_END_WRAPPER[gnu.xml.xpath.LastFunction]

} // end of class: LastFunction

} // end of namespace: gnu.xml.xpath
