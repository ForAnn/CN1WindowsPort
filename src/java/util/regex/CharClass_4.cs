// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class CharClass_24: global::java.util.regex.AbstractCharClass {
public global::java.util.regex.CharClass _fthis_20;

private bool _fval_2curAlt;

private global::java.util.regex.AbstractCharClass _fval_2nb;

private global::java.util.regex.AbstractCharClass _fval_2cc;

public void @this(global::java.util.regex.CharClass n1, bool n2, global::java.util.regex.AbstractCharClass n3, global::java.util.regex.AbstractCharClass n4){
//XMLVM_BEGIN_WRAPPER[java.util.regex.CharClass$4: void <init>(java.util.regex.CharClass, boolean, java.util.regex.AbstractCharClass, java.util.regex.AbstractCharClass)]
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
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2 ? 1 : 0;
    _r3_o = n3;
    _r4_o = n4;
    ((global::java.util.regex.CharClass_24) _r0_o)._fthis_20 = (global::java.util.regex.CharClass) _r1_o;
    ((global::java.util.regex.CharClass_24) _r0_o)._fval_2curAlt = 0!=_r2.i;
    ((global::java.util.regex.CharClass_24) _r0_o)._fval_2nb = (global::java.util.regex.AbstractCharClass) _r3_o;
    ((global::java.util.regex.CharClass_24) _r0_o)._fval_2cc = (global::java.util.regex.AbstractCharClass) _r4_o;
    ((global::java.util.regex.AbstractCharClass) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.regex.CharClass$4: void <init>(java.util.regex.CharClass, boolean, java.util.regex.AbstractCharClass, java.util.regex.AbstractCharClass)]
}

public override bool contains(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.CharClass$4: boolean contains(int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5.i = n1;
    _r3.i = 1;
    _r2.i = 0;
    _r0.i = ((global::java.util.regex.CharClass_24) _r4_o)._fval_2curAlt ? 1 : 0;
    _r1_o = ((global::java.util.regex.CharClass_24) _r4_o)._fval_2nb;
    _r1.i = ((global::java.util.regex.AbstractCharClass) _r1_o).contains((int) _r5.i) ? 1 : 0;
    if (_r1.i != 0) goto label26;
    _r1_o = ((global::java.util.regex.CharClass_24) _r4_o)._fval_2cc;
    _r1.i = ((global::java.util.regex.AbstractCharClass) _r1_o).contains((int) _r5.i) ? 1 : 0;
    if (_r1.i != 0) goto label26;
    _r1.i = _r2.i;
    label21:;
    _r0.i = _r0.i ^ _r1.i;
    if (_r0.i == 0) goto label28;
    _r0.i = _r2.i;
    label25:;
    return _r0.i!=0;
    label26:;
    _r1.i = _r3.i;
    goto label21;
    label28:;
    _r0.i = _r3.i;
    goto label25;
//XMLVM_END_WRAPPER[java.util.regex.CharClass$4: boolean contains(int)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.CharClass$4]
//XMLVM_END_WRAPPER[java.util.regex.CharClass$4]

} // end of class: CharClass_24

} // end of namespace: java.util.regex
