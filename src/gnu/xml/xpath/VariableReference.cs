// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.xpath {
public class VariableReference: global::gnu.xml.xpath.Expr {
public global::javax.xml.xpath.XPathVariableResolver _fresolver;

public global::javax.xml.@namespace.QName _fname;

public void @this(global::javax.xml.xpath.XPathVariableResolver n1, global::javax.xml.@namespace.QName n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.VariableReference: void <init>(javax.xml.xpath.XPathVariableResolver, javax.xml.namespace.QName)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::gnu.xml.xpath.Expr) _r0_o).@this();
    ((global::gnu.xml.xpath.VariableReference) _r0_o)._fresolver = (global::javax.xml.xpath.XPathVariableResolver) _r1_o;
    ((global::gnu.xml.xpath.VariableReference) _r0_o)._fname = (global::javax.xml.@namespace.QName) _r2_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.VariableReference: void <init>(javax.xml.xpath.XPathVariableResolver, javax.xml.namespace.QName)]
}

public override global::System.Object evaluate(global::org.w3c.dom.Node n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.VariableReference: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2;
    _r5.i = n3;
    _r0_o = ((global::gnu.xml.xpath.VariableReference) _r2_o)._fresolver;
    if (_r0_o == null) goto label30;
    _r0_o = ((global::gnu.xml.xpath.VariableReference) _r2_o)._fresolver;
// Red class access removed: gnu.xml.transform.Bindings instance-of
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: gnu.xml.transform.Bindings instance-of");
    if (_r0.i == 0) goto label21;
    _r0_o = ((global::gnu.xml.xpath.VariableReference) _r2_o)._fresolver;
// Red class access removed: gnu.xml.transform.Bindings check-cast
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: gnu.xml.transform.Bindings check-cast");
    _r1_o = ((global::gnu.xml.xpath.VariableReference) _r2_o)._fname;
// Red class access removed: gnu.xml.transform.Bindings get
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: gnu.xml.transform.Bindings get");
    label20:;
    return (global::java.lang.Object) _r0_o;
    label21:;
    _r0_o = ((global::gnu.xml.xpath.VariableReference) _r2_o)._fresolver;
    _r1_o = ((global::gnu.xml.xpath.VariableReference) _r2_o)._fname;
    _r0_o = ((global::javax.xml.xpath.XPathVariableResolver) _r0_o).resolveVariable((global::javax.xml.@namespace.QName) _r1_o);
    goto label20;
    label30:;
    _r0_o = new global::java.lang.IllegalStateException();
    // Value=no variable resolver
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::java.lang.IllegalStateException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.xpath.VariableReference: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
}

public override global::System.Object clone(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.VariableReference: gnu.xml.xpath.Expr clone(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::gnu.xml.xpath.VariableReference) _r3_o)._fresolver;
    _r1.i = ((_r4_o != null) && (_r4_o is global::javax.xml.xpath.XPathVariableResolver)) ? 1 : 0;
    if (_r1.i == 0) goto label9;
    _r4_o = _r4_o;
    _r0_o = _r4_o;
    label9:;
    _r1_o = new global::gnu.xml.xpath.VariableReference();
    _r2_o = ((global::gnu.xml.xpath.VariableReference) _r3_o)._fname;
    ((global::gnu.xml.xpath.VariableReference) _r1_o).@this((global::javax.xml.xpath.XPathVariableResolver) _r0_o, (global::javax.xml.@namespace.QName) _r2_o);
    return (global::gnu.xml.xpath.Expr) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.VariableReference: gnu.xml.xpath.Expr clone(java.lang.Object)]
}

public override bool references(global::javax.xml.@namespace.QName n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.VariableReference: boolean references(javax.xml.namespace.QName)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.xpath.VariableReference) _r1_o)._fname;
    _r0.i = ((global::javax.xml.@namespace.QName) _r0_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.xpath.VariableReference: boolean references(javax.xml.namespace.QName)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.VariableReference: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = new global::gnu.java.lang.CPStringBuilder();
    // Value=$
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1_o = ((global::gnu.xml.xpath.VariableReference) _r3_o)._fname;
    _r1_o = ((global::javax.xml.@namespace.QName) _r1_o).getPrefix();
    if (_r1_o == null) goto label31;
    // Value=
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r2.i != 0) goto label31;
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = 58;
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((char) _r1.i);
    label31:;
    _r1_o = ((global::gnu.xml.xpath.VariableReference) _r3_o)._fname;
    _r1_o = ((global::javax.xml.@namespace.QName) _r1_o).getLocalPart();
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::gnu.java.lang.CPStringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.VariableReference: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.VariableReference]
//XMLVM_END_WRAPPER[gnu.xml.xpath.VariableReference]

} // end of class: VariableReference

} // end of namespace: gnu.xml.xpath
