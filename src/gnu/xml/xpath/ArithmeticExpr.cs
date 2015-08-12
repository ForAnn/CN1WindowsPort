// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.xpath {
public class ArithmeticExpr: global::gnu.xml.xpath.Expr {
public static int _fADD = 0;

public static int _fSUBTRACT = 1;

public static int _fMULTIPLY = 2;

public static int _fDIVIDE = 3;

public static int _fMODULO = 4;

public global::gnu.xml.xpath.Expr _flhs;

public global::gnu.xml.xpath.Expr _frhs;

public int _fop;

public void @this(global::gnu.xml.xpath.Expr n1, global::gnu.xml.xpath.Expr n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.ArithmeticExpr: void <init>(gnu.xml.xpath.Expr, gnu.xml.xpath.Expr, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    ((global::gnu.xml.xpath.Expr) _r1_o).@this();
    ((global::gnu.xml.xpath.ArithmeticExpr) _r1_o)._flhs = (global::gnu.xml.xpath.Expr) _r2_o;
    ((global::gnu.xml.xpath.ArithmeticExpr) _r1_o)._frhs = (global::gnu.xml.xpath.Expr) _r3_o;
    switch (_r4.i) {
    case 0: goto label16;
    case 1: goto label16;
    case 2: goto label16;
    case 3: goto label16;
    case 4: goto label16;
    }
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label16:;
    ((global::gnu.xml.xpath.ArithmeticExpr) _r1_o)._fop = _r4.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.ArithmeticExpr: void <init>(gnu.xml.xpath.Expr, gnu.xml.xpath.Expr, int)]
}

public override global::System.Object evaluate(global::org.w3c.dom.Node n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.ArithmeticExpr: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    _r6_o = this;
    _r7_o = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r0_o = ((global::gnu.xml.xpath.ArithmeticExpr) _r6_o)._flhs;
    _r0_o = ((global::gnu.xml.xpath.Expr) _r0_o).evaluate((global::org.w3c.dom.Node) _r7_o, (int) _r8.i, (int) _r9.i);
    _r1_o = ((global::gnu.xml.xpath.ArithmeticExpr) _r6_o)._frhs;
    _r1_o = ((global::gnu.xml.xpath.Expr) _r1_o).evaluate((global::org.w3c.dom.Node) _r7_o, (int) _r8.i, (int) _r9.i);
    _r2.d = global::gnu.xml.xpath.ArithmeticExpr._1number((global::org.w3c.dom.Node) _r7_o, (global::java.lang.Object) _r0_o);
    _r0.d = global::gnu.xml.xpath.ArithmeticExpr._1number((global::org.w3c.dom.Node) _r7_o, (global::java.lang.Object) _r1_o);
    _r4.i = ((global::gnu.xml.xpath.ArithmeticExpr) _r6_o)._fop;
    switch (_r4.i) {
    case 0: goto label31;
    case 1: goto label39;
    case 2: goto label48;
    case 3: goto label56;
    case 4: goto label114;
    }
    _r0_o = new global::java.lang.IllegalStateException();
    ((global::java.lang.IllegalStateException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
    label31:;
    _r4_o = new global::java.lang.Double();
    _r0.d = _r0.d + _r2.d;
    ((global::java.lang.Double) _r4_o).@this((double) _r0.d);
    _r0_o = _r4_o;
    label38:;
    return (global::java.lang.Object) _r0_o;
    label39:;
    _r4_o = new global::java.lang.Double();
    _r0.d = _r2.d - _r0.d;
    ((global::java.lang.Double) _r4_o).@this((double) _r0.d);
    _r0_o = _r4_o;
    goto label38;
    label48:;
    _r4_o = new global::java.lang.Double();
    _r0.d = _r0.d * _r2.d;
    ((global::java.lang.Double) _r4_o).@this((double) _r0.d);
    _r0_o = _r4_o;
    goto label38;
    label56:;
    _r4.d = 0.0D;
    _r4.i = _r0.d > _r4.d ? 1 : (_r0.d == _r4.d ? 0 : -1);
    if (_r4.i == 0) goto label68;
    _r4.d = -0.0D;
    _r4.i = _r0.d > _r4.d ? 1 : (_r0.d == _r4.d ? 0 : -1);
    if (_r4.i != 0) goto label105;
    label68:;
    _r0.d = 0.0D;
    _r0.i = _r2.d > _r0.d ? 1 : (_r2.d == _r0.d ? 0 : -1);
    if (_r0.i == 0) goto label80;
    _r0.d = -0.0D;
    _r0.i = _r2.d > _r0.d ? 1 : (_r2.d == _r0.d ? 0 : -1);
    if (_r0.i != 0) goto label88;
    label80:;
    _r0_o = new global::java.lang.Double();
    _r1.d = global::System.Double.NaN;
    ((global::java.lang.Double) _r0_o).@this((double) _r1.d);
    goto label38;
    label88:;
    _r0_o = new global::java.lang.Double();
    _r4.d = 0.0D;
    _r1.i = _r2.d > _r4.d ? 1 : (_r2.d == _r4.d ? 0 : -1);
    if (_r1.i >= 0) goto label102;
    _r1.d = global::System.Double.NegativeInfinity;
    label98:;
    ((global::java.lang.Double) _r0_o).@this((double) _r1.d);
    goto label38;
    label102:;
    _r1.d = global::System.Double.PositiveInfinity;
    goto label98;
    label105:;
    _r4_o = new global::java.lang.Double();
    _r0.d = _r2.d / _r0.d;
    ((global::java.lang.Double) _r4_o).@this((double) _r0.d);
    _r0_o = _r4_o;
    goto label38;
    label114:;
    _r4.d = 0.0D;
    _r4.i = _r0.d > _r4.d ? 1 : (_r0.d == _r4.d ? 0 : -1);
    if (_r4.i == 0) goto label126;
    _r4.d = 0.0D;
    _r4.i = _r0.d > _r4.d ? 1 : (_r0.d == _r4.d ? 0 : -1);
    if (_r4.i != 0) goto label163;
    label126:;
    _r0.d = 0.0D;
    _r0.i = _r2.d > _r0.d ? 1 : (_r2.d == _r0.d ? 0 : -1);
    if (_r0.i == 0) goto label138;
    _r0.d = -0.0D;
    _r0.i = _r2.d > _r0.d ? 1 : (_r2.d == _r0.d ? 0 : -1);
    if (_r0.i != 0) goto label146;
    label138:;
    _r0_o = new global::java.lang.Double();
    _r1.d = global::System.Double.NaN;
    ((global::java.lang.Double) _r0_o).@this((double) _r1.d);
    goto label38;
    label146:;
    _r0_o = new global::java.lang.Double();
    _r4.d = 0.0D;
    _r1.i = _r2.d > _r4.d ? 1 : (_r2.d == _r4.d ? 0 : -1);
    if (_r1.i >= 0) goto label160;
    _r1.d = global::System.Double.NegativeInfinity;
    label156:;
    ((global::java.lang.Double) _r0_o).@this((double) _r1.d);
    goto label38;
    label160:;
    _r1.d = global::System.Double.PositiveInfinity;
    goto label156;
    label163:;
    _r4_o = new global::java.lang.Double();
      throw new global::org.xmlvm._nNotYetImplementedException("dex:rem-double");
    ((global::java.lang.Double) _r4_o).@this((double) _r0.d);
    _r0_o = _r4_o;
    goto label38;
//XMLVM_END_WRAPPER[gnu.xml.xpath.ArithmeticExpr: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
}

public override global::System.Object clone(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.ArithmeticExpr: gnu.xml.xpath.Expr clone(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0_o = new global::gnu.xml.xpath.ArithmeticExpr();
    _r1_o = ((global::gnu.xml.xpath.ArithmeticExpr) _r4_o)._flhs;
    _r1_o = ((global::gnu.xml.xpath.Expr) _r1_o).clone((global::java.lang.Object) _r5_o);
    _r2_o = ((global::gnu.xml.xpath.ArithmeticExpr) _r4_o)._frhs;
    _r2_o = ((global::gnu.xml.xpath.Expr) _r2_o).clone((global::java.lang.Object) _r5_o);
    _r3.i = ((global::gnu.xml.xpath.ArithmeticExpr) _r4_o)._fop;
    ((global::gnu.xml.xpath.ArithmeticExpr) _r0_o).@this((global::gnu.xml.xpath.Expr) _r1_o, (global::gnu.xml.xpath.Expr) _r2_o, (int) _r3.i);
    return (global::gnu.xml.xpath.Expr) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.ArithmeticExpr: gnu.xml.xpath.Expr clone(java.lang.Object)]
}

public override bool references(global::javax.xml.@namespace.QName n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.ArithmeticExpr: boolean references(javax.xml.namespace.QName)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.xpath.ArithmeticExpr) _r1_o)._flhs;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    if (_r0.i != 0) goto label18;
    _r0_o = ((global::gnu.xml.xpath.ArithmeticExpr) _r1_o)._frhs;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    if (_r0.i != 0) goto label18;
    _r0.i = 0;
    label17:;
    return _r0.i!=0;
    label18:;
    _r0.i = 1;
    goto label17;
//XMLVM_END_WRAPPER[gnu.xml.xpath.ArithmeticExpr: boolean references(javax.xml.namespace.QName)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.ArithmeticExpr: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r2.i = 32;
    _r0_o = new global::gnu.java.lang.CPStringBuilder();
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).@this();
    _r1_o = ((global::gnu.xml.xpath.ArithmeticExpr) _r3_o)._flhs;
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((char) _r2.i);
    _r1.i = ((global::gnu.xml.xpath.ArithmeticExpr) _r3_o)._fop;
    switch (_r1.i) {
    case 0: goto label33;
    case 1: goto label39;
    case 2: goto label45;
    case 3: goto label51;
    case 4: goto label57;
    }
    label20:;
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((char) _r2.i);
    _r1_o = ((global::gnu.xml.xpath.ArithmeticExpr) _r3_o)._frhs;
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    _r0_o = ((global::gnu.java.lang.CPStringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
    label33:;
    _r1.i = 43;
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((char) _r1.i);
    goto label20;
    label39:;
    _r1.i = 45;
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((char) _r1.i);
    goto label20;
    label45:;
    _r1.i = 42;
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((char) _r1.i);
    goto label20;
    label51:;
    // Value=div
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    goto label20;
    label57:;
    // Value=mod
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    goto label20;
//XMLVM_END_WRAPPER[gnu.xml.xpath.ArithmeticExpr: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.ArithmeticExpr]
//XMLVM_END_WRAPPER[gnu.xml.xpath.ArithmeticExpr]

} // end of class: ArithmeticExpr

} // end of namespace: gnu.xml.xpath
