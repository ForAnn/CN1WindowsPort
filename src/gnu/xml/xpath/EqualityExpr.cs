// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.xpath {
public class EqualityExpr: global::gnu.xml.xpath.Expr {
public global::gnu.xml.xpath.Expr _flhs;

public global::gnu.xml.xpath.Expr _frhs;

public bool _finvert;

public void @this(global::gnu.xml.xpath.Expr n1, global::gnu.xml.xpath.Expr n2, bool n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.EqualityExpr: void <init>(gnu.xml.xpath.Expr, gnu.xml.xpath.Expr, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3.i = n3 ? 1 : 0;
    ((global::gnu.xml.xpath.Expr) _r0_o).@this();
    ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._flhs = (global::gnu.xml.xpath.Expr) _r1_o;
    ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._frhs = (global::gnu.xml.xpath.Expr) _r2_o;
    ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._finvert = 0!=_r3.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.xpath.EqualityExpr: void <init>(gnu.xml.xpath.Expr, gnu.xml.xpath.Expr, boolean)]
}

public override global::System.Object evaluate(global::org.w3c.dom.Node n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.EqualityExpr: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2;
    _r5.i = n3;
    _r0.i = ((global::gnu.xml.xpath.EqualityExpr) _r2_o).evaluateImpl((global::org.w3c.dom.Node) _r3_o, (int) _r4.i, (int) _r5.i) ? 1 : 0;
    _r1.i = ((global::gnu.xml.xpath.EqualityExpr) _r2_o)._finvert ? 1 : 0;
    if (_r1.i == 0) goto label16;
    if (_r0.i == 0) goto label13;
    _r0_o = global::java.lang.Boolean._fFALSE;
    label12:;
    return (global::java.lang.Object) _r0_o;
    label13:;
    _r0_o = global::java.lang.Boolean._fTRUE;
    goto label12;
    label16:;
    if (_r0.i == 0) goto label21;
    _r0_o = global::java.lang.Boolean._fTRUE;
    goto label12;
    label21:;
    _r0_o = global::java.lang.Boolean._fFALSE;
    goto label12;
//XMLVM_END_WRAPPER[gnu.xml.xpath.EqualityExpr: java.lang.Object evaluate(org.w3c.dom.Node, int, int)]
}

private bool evaluateImpl(global::org.w3c.dom.Node n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.EqualityExpr: boolean evaluateImpl(org.w3c.dom.Node, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::org.xmlvm._nElement _r13;
    global::org.xmlvm._nElement _r14;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r16_o = null;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::org.xmlvm._nElement _r19;
    _r16_o = this;
    _r17_o = n1;
    _r18.i = n2;
    _r19.i = n3;
    _r15.i = 0;
    _r14.i = 1;
    _r0_o = _r16_o;
    _r0_o = ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._flhs;
    _r4_o = _r0_o;
    _r0_o = _r4_o;
    _r1_o = _r17_o;
    _r2.i = _r18.i;
    _r3.i = _r19.i;
    _r4_o = ((global::gnu.xml.xpath.Expr) _r0_o).evaluate((global::org.w3c.dom.Node) _r1_o, (int) _r2.i, (int) _r3.i);
    _r0_o = _r16_o;
    _r0_o = ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._frhs;
    _r5_o = _r0_o;
    _r0_o = _r5_o;
    _r1_o = _r17_o;
    _r2.i = _r18.i;
    _r3.i = _r19.i;
    _r5_o = ((global::gnu.xml.xpath.Expr) _r0_o).evaluate((global::org.w3c.dom.Node) _r1_o, (int) _r2.i, (int) _r3.i);
    _r6.i = ((_r4_o != null) && (_r4_o is global::java.util.Collection)) ? 1 : 0;
    _r7.i = ((_r5_o != null) && (_r5_o is global::java.util.Collection)) ? 1 : 0;
    if (_r6.i == 0) goto label134;
    if (_r7.i == 0) goto label134;
    _r6.i = ((global::java.util.Collection) _r4_o).isEmpty() ? 1 : 0;
    if (_r6.i == 0) goto label54;
    _r4.i = _r15.i;
    label53:;
    return _r4.i!=0;
    label54:;
    _r7_o = ((global::java.util.Collection) _r4_o).iterator();
    _r6.i = _r14.i;
    label59:;
    _r4.i = ((global::java.util.Iterator) _r7_o).hasNext() ? 1 : 0;
    if (_r4.i != 0) goto label67;
    _r4.i = _r6.i;
    goto label53;
    label67:;
    _r4_o = ((global::java.util.Iterator) _r7_o).next();
    _r8_o = ((global::java.util.Collection) _r5_o).iterator();
    _r9.i = _r6.i;
    label78:;
    _r6.i = ((global::java.util.Iterator) _r8_o).hasNext() ? 1 : 0;
    if (_r6.i != 0) goto label86;
    _r6.i = _r9.i;
    goto label59;
    label86:;
    _r6_o = ((global::java.util.Iterator) _r8_o).next();
    if (_r4_o == _r6_o) goto label100;
    _r10.i = ((global::java.lang.Object) _r4_o).equals((global::java.lang.Object) _r6_o) ? 1 : 0;
    if (_r10.i == 0) goto label109;
    label100:;
    _r0_o = _r16_o;
    _r0.i = ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._finvert ? 1 : 0;
    _r6.i = _r0.i;
    if (_r6.i != 0) goto label78;
    _r4.i = _r14.i;
    goto label53;
    label109:;
    _r10_o = global::gnu.xml.xpath.EqualityExpr.stringValue((global::org.w3c.dom.Node) _r4_o);
    _r6_o = global::gnu.xml.xpath.EqualityExpr.stringValue((global::org.w3c.dom.Node) _r6_o);
    _r6.i = ((global::java.lang.String) _r10_o).equals((global::java.lang.Object) _r6_o) ? 1 : 0;
    if (_r6.i == 0) goto label132;
    _r0_o = _r16_o;
    _r0.i = ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._finvert ? 1 : 0;
    _r6.i = _r0.i;
    if (_r6.i != 0) goto label78;
    _r4.i = _r14.i;
    goto label53;
    label132:;
    _r9.i = _r15.i;
    goto label78;
    label134:;
    _r8.i = ((_r4_o != null) && (_r4_o is global::java.lang.Double)) ? 1 : 0;
    _r9.i = ((_r5_o != null) && (_r5_o is global::java.lang.Double)) ? 1 : 0;
    if (_r6.i == 0) goto label142;
    if (_r9.i != 0) goto label146;
    label142:;
    if (_r7.i == 0) goto label230;
    if (_r8.i == 0) goto label230;
    label146:;
    if (_r6.i == 0) goto label181;
    _r0_o = _r4_o;
    _r6_o = _r0_o;
    label152:;
    if (_r8.i == 0) goto label186;
    _r4.d = ((global::java.lang.Double) _r4_o).doubleValue();
    _r7.d = _r4.d;
    label161:;
    _r5_o = ((global::java.util.Collection) _r6_o).iterator();
    _r6.i = _r14.i;
    label166:;
    _r4.i = ((global::java.util.Iterator) _r5_o).hasNext() ? 1 : 0;
    if (_r4.i != 0) goto label194;
    _r0_o = _r16_o;
    _r0.i = ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._finvert ? 1 : 0;
    _r4.i = _r0.i;
    if (_r4.i == 0) goto label227;
    _r4.i = _r6.i;
    goto label53;
    label181:;
    _r0_o = _r5_o;
    _r6_o = _r0_o;
    goto label152;
    label186:;
    _r4.d = ((global::java.lang.Double) _r5_o).doubleValue();
    _r7.d = _r4.d;
    goto label161;
    label194:;
    _r4_o = ((global::java.util.Iterator) _r5_o).next();
    _r4_o = global::gnu.xml.xpath.EqualityExpr.stringValue((global::org.w3c.dom.Node) _r4_o);
    _r0_o = _r17_o;
    _r1_o = _r4_o;
    _r9.d = global::gnu.xml.xpath.EqualityExpr._1number((global::org.w3c.dom.Node) _r0_o, (global::java.lang.Object) _r1_o);
    _r4.i = _r9.d > _r7.d ? 1 : (_r9.d == _r7.d ? 0 : -1);
    if (_r4.i != 0) goto label225;
    _r0_o = _r16_o;
    _r0.i = ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._finvert ? 1 : 0;
    _r4.i = _r0.i;
    if (_r4.i != 0) goto label166;
    _r4.i = _r14.i;
    goto label53;
    label225:;
    _r6.i = _r15.i;
    goto label166;
    label227:;
    _r4.i = _r15.i;
    goto label53;
    label230:;
    _r10.i = ((_r4_o != null) && (_r4_o is global::java.lang.String)) ? 1 : 0;
    _r11.i = ((_r5_o != null) && (_r5_o is global::java.lang.String)) ? 1 : 0;
    if (_r6.i == 0) goto label238;
    if (_r11.i != 0) goto label242;
    label238:;
    if (_r7.i == 0) goto label313;
    if (_r10.i == 0) goto label313;
    label242:;
    if (_r6.i == 0) goto label274;
    _r0_o = _r4_o;
    _r6_o = _r0_o;
    label248:;
    if (_r10.i == 0) goto label279;
    _r5_o = _r4_o;
    label253:;
    _r6_o = ((global::java.util.Collection) _r6_o).iterator();
    _r7.i = _r14.i;
    label258:;
    _r4.i = ((global::java.util.Iterator) _r6_o).hasNext() ? 1 : 0;
    if (_r4.i != 0) goto label282;
    _r0_o = _r16_o;
    _r0.i = ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._finvert ? 1 : 0;
    _r4.i = _r0.i;
    if (_r4.i == 0) goto label310;
    _r4.i = _r7.i;
    goto label53;
    label274:;
    _r0_o = _r5_o;
    _r6_o = _r0_o;
    goto label248;
    label279:;
    goto label253;
    label282:;
    _r4_o = ((global::java.util.Iterator) _r6_o).next();
    _r4_o = global::gnu.xml.xpath.EqualityExpr.stringValue((global::org.w3c.dom.Node) _r4_o);
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r4.i == 0) goto label308;
    _r0_o = _r16_o;
    _r0.i = ((global::gnu.xml.xpath.EqualityExpr) _r0_o)._finvert ? 1 : 0;
    _r4.i = _r0.i;
    if (_r4.i != 0) goto label258;
    _r4.i = _r14.i;
    goto label53;
    label308:;
    _r7.i = _r15.i;
    goto label258;
    label310:;
    _r4.i = _r15.i;
    goto label53;
    label313:;
    _r12.i = ((_r4_o != null) && (_r4_o is global::java.lang.Boolean)) ? 1 : 0;
    _r13.i = ((_r5_o != null) && (_r5_o is global::java.lang.Boolean)) ? 1 : 0;
    if (_r6.i == 0) goto label321;
    if (_r13.i != 0) goto label325;
    label321:;
    if (_r7.i == 0) goto label366;
    if (_r12.i == 0) goto label366;
    label325:;
    if (_r6.i == 0) goto label351;
    _r0_o = _r4_o;
    _r6_o = _r0_o;
    label331:;
    if (_r12.i == 0) goto label356;
    _r4.i = ((global::java.lang.Boolean) _r4_o).booleanValue() ? 1 : 0;
    label339:;
    _r0_o = _r17_o;
    _r1_o = _r6_o;
    _r5.i = global::gnu.xml.xpath.EqualityExpr._1boolean((global::org.w3c.dom.Node) _r0_o, (global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r5.i != _r4.i) goto label363;
    _r4.i = _r14.i;
    goto label53;
    label351:;
    _r0_o = _r5_o;
    _r6_o = _r0_o;
    goto label331;
    label356:;
    _r4.i = ((global::java.lang.Boolean) _r5_o).booleanValue() ? 1 : 0;
    goto label339;
    label363:;
    _r4.i = _r15.i;
    goto label53;
    label366:;
    if (_r12.i != 0) goto label370;
    if (_r13.i == 0) goto label410;
    label370:;
    if (_r12.i == 0) goto label391;
    _r4.i = ((global::java.lang.Boolean) _r4_o).booleanValue() ? 1 : 0;
    label378:;
    if (_r13.i == 0) goto label399;
    _r5.i = ((global::java.lang.Boolean) _r5_o).booleanValue() ? 1 : 0;
    label386:;
    if (_r4.i != _r5.i) goto label407;
    _r4.i = _r14.i;
    goto label53;
    label391:;
    _r0_o = _r17_o;
    _r1_o = _r4_o;
    _r4.i = global::gnu.xml.xpath.EqualityExpr._1boolean((global::org.w3c.dom.Node) _r0_o, (global::java.lang.Object) _r1_o) ? 1 : 0;
    goto label378;
    label399:;
    _r0_o = _r17_o;
    _r1_o = _r5_o;
    _r5.i = global::gnu.xml.xpath.EqualityExpr._1boolean((global::org.w3c.dom.Node) _r0_o, (global::java.lang.Object) _r1_o) ? 1 : 0;
    goto label386;
    label407:;
    _r4.i = _r15.i;
    goto label53;
    label410:;
    if (_r8.i != 0) goto label414;
    if (_r9.i == 0) goto label456;
    label414:;
    if (_r8.i == 0) goto label437;
    _r6.d = ((global::java.lang.Double) _r4_o).doubleValue();
    label422:;
    if (_r9.i == 0) goto label445;
    _r4.d = ((global::java.lang.Double) _r5_o).doubleValue();
    label430:;
    _r4.i = _r6.d > _r4.d ? 1 : (_r6.d == _r4.d ? 0 : -1);
    if (_r4.i != 0) goto label453;
    _r4.i = _r14.i;
    goto label53;
    label437:;
    _r0_o = _r17_o;
    _r1_o = _r4_o;
    _r6.d = global::gnu.xml.xpath.EqualityExpr._1number((global::org.w3c.dom.Node) _r0_o, (global::java.lang.Object) _r1_o);
    goto label422;
    label445:;
    _r0_o = _r17_o;
    _r1_o = _r5_o;
    _r4.d = global::gnu.xml.xpath.EqualityExpr._1number((global::org.w3c.dom.Node) _r0_o, (global::java.lang.Object) _r1_o);
    goto label430;
    label453:;
    _r4.i = _r15.i;
    goto label53;
    label456:;
    if (_r10.i == 0) goto label470;
    label460:;
    if (_r11.i == 0) goto label478;
    label464:;
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    goto label53;
    label470:;
    _r0_o = _r17_o;
    _r1_o = _r4_o;
    _r4_o = global::gnu.xml.xpath.EqualityExpr._1string((global::org.w3c.dom.Node) _r0_o, (global::java.lang.Object) _r1_o);
    goto label460;
    label478:;
    _r0_o = _r17_o;
    _r1_o = _r5_o;
    _r5_o = global::gnu.xml.xpath.EqualityExpr._1string((global::org.w3c.dom.Node) _r0_o, (global::java.lang.Object) _r1_o);
    goto label464;
//XMLVM_END_WRAPPER[gnu.xml.xpath.EqualityExpr: boolean evaluateImpl(org.w3c.dom.Node, int, int)]
}

public override global::System.Object clone(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.EqualityExpr: gnu.xml.xpath.Expr clone(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0_o = new global::gnu.xml.xpath.EqualityExpr();
    _r1_o = ((global::gnu.xml.xpath.EqualityExpr) _r4_o)._flhs;
    _r1_o = ((global::gnu.xml.xpath.Expr) _r1_o).clone((global::java.lang.Object) _r5_o);
    _r2_o = ((global::gnu.xml.xpath.EqualityExpr) _r4_o)._frhs;
    _r2_o = ((global::gnu.xml.xpath.Expr) _r2_o).clone((global::java.lang.Object) _r5_o);
    _r3.i = ((global::gnu.xml.xpath.EqualityExpr) _r4_o)._finvert ? 1 : 0;
    ((global::gnu.xml.xpath.EqualityExpr) _r0_o).@this((global::gnu.xml.xpath.Expr) _r1_o, (global::gnu.xml.xpath.Expr) _r2_o, 0!=_r3.i);
    return (global::gnu.xml.xpath.Expr) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.xpath.EqualityExpr: gnu.xml.xpath.Expr clone(java.lang.Object)]
}

public override bool references(global::javax.xml.@namespace.QName n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.EqualityExpr: boolean references(javax.xml.namespace.QName)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.xpath.EqualityExpr) _r1_o)._flhs;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    if (_r0.i != 0) goto label18;
    _r0_o = ((global::gnu.xml.xpath.EqualityExpr) _r1_o)._frhs;
    _r0.i = ((global::gnu.xml.xpath.Expr) _r0_o).references((global::javax.xml.@namespace.QName) _r2_o) ? 1 : 0;
    if (_r0.i != 0) goto label18;
    _r0.i = 0;
    label17:;
    return _r0.i!=0;
    label18:;
    _r0.i = 1;
    goto label17;
//XMLVM_END_WRAPPER[gnu.xml.xpath.EqualityExpr: boolean references(javax.xml.namespace.QName)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.EqualityExpr: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::gnu.xml.xpath.EqualityExpr) _r2_o)._finvert ? 1 : 0;
    if (_r0.i == 0) goto label32;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = ((global::gnu.xml.xpath.EqualityExpr) _r2_o)._flhs;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value= != 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 33)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::gnu.xml.xpath.EqualityExpr) _r2_o)._frhs;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    label31:;
    return (global::java.lang.String) _r0_o;
    label32:;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = ((global::gnu.xml.xpath.EqualityExpr) _r2_o)._flhs;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value= = 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::gnu.xml.xpath.EqualityExpr) _r2_o)._frhs;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label31;
//XMLVM_END_WRAPPER[gnu.xml.xpath.EqualityExpr: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.xpath.EqualityExpr]
//XMLVM_END_WRAPPER[gnu.xml.xpath.EqualityExpr]

} // end of class: EqualityExpr

} // end of namespace: gnu.xml.xpath
