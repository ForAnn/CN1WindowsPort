// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class AbstractCharClass_21: global::java.util.regex.AbstractCharClass {
public global::java.util.regex.AbstractCharClass _fthis_20;

private global::java.util.BitSet _fval_2lHS;

public void @this(global::java.util.regex.AbstractCharClass n1, global::java.util.BitSet n2){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$1: void <init>(java.util.regex.AbstractCharClass, java.util.BitSet)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.util.regex.AbstractCharClass_21) _r0_o)._fthis_20 = (global::java.util.regex.AbstractCharClass) _r1_o;
    ((global::java.util.regex.AbstractCharClass_21) _r0_o)._fval_2lHS = (global::java.util.BitSet) _r2_o;
    ((global::java.util.regex.AbstractCharClass) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$1: void <init>(java.util.regex.AbstractCharClass, java.util.BitSet)]
}

public override bool contains(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$1: boolean contains(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r0.i = 55296;
    _r0.i = _r4.i - _r0.i;
    if (_r0.i < 0) goto label21;
    _r1.i = global::java.util.regex.AbstractCharClass._fSURROGATE_1CARDINALITY;
    if (_r0.i >= _r1.i) goto label21;
    _r1.i = ((global::java.util.regex.AbstractCharClass_21) _r3_o)._faltSurrogates ? 1 : 0;
    _r2_o = ((global::java.util.regex.AbstractCharClass_21) _r3_o)._fval_2lHS;
    _r0.i = ((global::java.util.BitSet) _r2_o).get((int) _r0.i) ? 1 : 0;
    _r0.i = _r0.i ^ _r1.i;
    label20:;
    return _r0.i!=0;
    label21:;
    _r0.i = 0;
    goto label20;
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$1: boolean contains(int)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$1]
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$1]

} // end of class: AbstractCharClass_21

} // end of namespace: java.util.regex
