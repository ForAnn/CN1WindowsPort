// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.xpath {
public class FloorFunction: global::gnu.xml.xpath.Expr {
public global::gnu.xml.xpath.Expr _farg;

public void @this(global::java.util.List n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.FloorFunction: void <init>(java.util.List)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    _r0_o = ((global::java.util.List) _r2_o).get((int) _r0.i);
    ((global::gnu.xml.xpath.FloorFunction) _r1_o).@this((global::gnu.xml.xpath.Expr) _r0_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.FloorFunction: void <init>(java.util.List)]
}

public void @this(global::gnu.xml.xpath.Expr n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.FloorFunction: void <init>(gnu.xml.xpath.Expr)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::gnu.xml.xpath.Expr) _r0_o).@this();
    ((global::gnu.xml.xpath.FloorFunction) _r0_o)._farg = (global::gnu.xml.xpath.Expr) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.FloorFunction: void <init>(gnu.xml.xpath.Expr)]
}

public override global::System.Object evaluate(global::org.w3c.dom.Node n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.FloorFunction: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r6.i = n3;
    _r0_o = ((global::gnu.xml.xpath.FloorFunction) _r3_o)._farg;
    _r0_o = ((global::gnu.xml.xpath.Expr) _r0_o).evaluate((global::org.w3c.dom.Node) _r4_o, (int) _r5.i, (int) _r6.i);
    _r0.d = global::gnu.xml.xpath.FloorFunction._1number((global::org.w3c.dom.Node) _r4_o, (global::java.lang.Object) _r0_o);
    _r2_o = new global::java.lang.Double();
    _r0.d = global::java.lang.Math.floor((double) _r0.d);
    ((global::java.lang.Double) _r2_o).@this((double) _r0.d);
    return (global::java.lang.Object) _r2_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.FloorFunction: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
}

public override global::System.Object clone(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.FloorFunction: gnu.xml.xpath.Expr clone(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = new global::gnu.xml.xpath.FloorFunction();
    _r1_o = ((global::gnu.xml.xpath.FloorFunction) _r2_o)._farg;
    _r1_o = ((global::gnu.xml.xpath.Expr) _r1_o).clone((global::java.lang.Object) _r3_o);
    ((global::gnu.xml.xpath.FloorFunction) _r0_o).@this((global::gnu.xml.xpath.Expr) _r1_o);
    return (global::gnu.xml.xpath.Expr) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.FloorFunction: gnu.xml.xpath.Expr clone(java.lang.Object)]
}

public override bool references(global::javax.xml.@namespace.QName n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.FloorFunction: boolean references(javax.xml.namespace.QName)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.xpath.FloorFunction) _r1_o)._farg;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.xpath.FloorFunction: boolean references(javax.xml.namespace.QName)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.FloorFunction: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=floor(
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 40))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1_o = ((global::gnu.xml.xpath.FloorFunction) _r2_o)._farg;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=)
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)41))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.FloorFunction: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.FloorFunction]
//XMLVM_END_WRAPPER[gnu.xml.xpath.FloorFunction]

} // end of class: FloorFunction

} // end of namespace: gnu.xml.xpath
