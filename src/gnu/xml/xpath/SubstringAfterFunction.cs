// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.xpath {
public class SubstringAfterFunction: global::gnu.xml.xpath.Expr {
public global::gnu.xml.xpath.Expr _farg1;

public global::gnu.xml.xpath.Expr _farg2;

public void @this(global::java.util.List n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: void <init>(java.util.List)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r0_o = ((global::java.util.List) _r3_o).get((int) _r0.i);
    _r0_o = _r0_o;
    _r1.i = 1;
    _r1_o = ((global::java.util.List) _r3_o).get((int) _r1.i);
    _r1_o = _r1_o;
    ((global::gnu.xml.xpath.SubstringAfterFunction) _r2_o).@this((global::gnu.xml.xpath.Expr) _r0_o, (global::gnu.xml.xpath.Expr) _r1_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: void <init>(java.util.List)]
}

public void @this(global::gnu.xml.xpath.Expr n1, global::gnu.xml.xpath.Expr n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: void <init>(gnu.xml.xpath.Expr, gnu.xml.xpath.Expr)]
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
    ((global::gnu.xml.xpath.Expr) _r0_o).@this();
    ((global::gnu.xml.xpath.SubstringAfterFunction) _r0_o)._farg1 = (global::gnu.xml.xpath.Expr) _r1_o;
    ((global::gnu.xml.xpath.SubstringAfterFunction) _r0_o)._farg2 = (global::gnu.xml.xpath.Expr) _r2_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: void <init>(gnu.xml.xpath.Expr, gnu.xml.xpath.Expr)]
}

public override global::System.Object evaluate(global::org.w3c.dom.Node n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r6.i = n2;
    _r7.i = n3;
    _r0_o = ((global::gnu.xml.xpath.SubstringAfterFunction) _r4_o)._farg1;
    _r0_o = ((global::gnu.xml.xpath.Expr) _r0_o).evaluate((global::org.w3c.dom.Node) _r5_o, (int) _r6.i, (int) _r7.i);
    _r1_o = ((global::gnu.xml.xpath.SubstringAfterFunction) _r4_o)._farg2;
    _r1_o = ((global::gnu.xml.xpath.Expr) _r1_o).evaluate((global::org.w3c.dom.Node) _r5_o, (int) _r6.i, (int) _r7.i);
    _r0_o = global::gnu.xml.xpath.SubstringAfterFunction._1string((global::org.w3c.dom.Node) _r5_o, (global::java.lang.Object) _r0_o);
    _r1_o = global::gnu.xml.xpath.SubstringAfterFunction._1string((global::org.w3c.dom.Node) _r5_o, (global::java.lang.Object) _r1_o);
    _r2.i = ((global::java.lang.String) _r0_o).indexOf((global::java.lang.String) _r1_o);
    _r3.i = -1;
    if (_r2.i != _r3.i) goto label30;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    label29:;
    return (global::java.lang.Object) _r0_o;
    label30:;
    _r1.i = ((global::java.lang.String) _r1_o).length();
    _r1.i = _r1.i + _r2.i;
    _r0_o = ((global::java.lang.String) _r0_o).substring((int) _r1.i);
    goto label29;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
}

public override global::System.Object clone(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: gnu.xml.xpath.Expr clone(java.lang.Object)]
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
    _r3_o = this;
    _r4_o = n1;
    _r0_o = new global::gnu.xml.xpath.SubstringAfterFunction();
    _r1_o = ((global::gnu.xml.xpath.SubstringAfterFunction) _r3_o)._farg1;
    _r1_o = ((global::gnu.xml.xpath.Expr) _r1_o).clone((global::java.lang.Object) _r4_o);
    _r2_o = ((global::gnu.xml.xpath.SubstringAfterFunction) _r3_o)._farg2;
    _r2_o = ((global::gnu.xml.xpath.Expr) _r2_o).clone((global::java.lang.Object) _r4_o);
    ((global::gnu.xml.xpath.SubstringAfterFunction) _r0_o).@this((global::gnu.xml.xpath.Expr) _r1_o, (global::gnu.xml.xpath.Expr) _r2_o);
    return (global::gnu.xml.xpath.Expr) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: gnu.xml.xpath.Expr clone(java.lang.Object)]
}

public override bool references(global::javax.xml.@namespace.QName n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: boolean references(javax.xml.namespace.QName)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.xpath.SubstringAfterFunction) _r1_o)._farg1;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    if (_r0.i != 0) goto label18;
    _r0_o = ((global::gnu.xml.xpath.SubstringAfterFunction) _r1_o)._farg2;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    if (_r0.i != 0) goto label18;
    _r0.i = 0;
    label17:;
    return _r0.i!=0;
    label18:;
    _r0.i = 1;
    goto label17;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: boolean references(javax.xml.namespace.QName)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=substring-after(
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 40))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1_o = ((global::gnu.xml.xpath.SubstringAfterFunction) _r2_o)._farg1;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=,
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::gnu.xml.xpath.SubstringAfterFunction) _r2_o)._farg2;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=)
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)41))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringAfterFunction: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.SubstringAfterFunction]
//XMLVM_END_WRAPPER[gnu.xml.xpath.SubstringAfterFunction]

} // end of class: SubstringAfterFunction

} // end of namespace: gnu.xml.xpath
