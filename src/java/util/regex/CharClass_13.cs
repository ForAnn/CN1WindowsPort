// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class CharClass_213: global::java.util.regex.AbstractCharClass {
public global::java.util.regex.CharClass _fthis_20;

private global::java.util.regex.AbstractCharClass _fval_2clazz;

public void @this(global::java.util.regex.CharClass n1, global::java.util.regex.AbstractCharClass n2){
//XMLVM_BEGIN_WRAPPER[java.util.regex.CharClass$13: void <init>(java.util.regex.CharClass, java.util.regex.AbstractCharClass)]
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
    ((global::java.util.regex.CharClass_213) _r0_o)._fthis_20 = (global::java.util.regex.CharClass) _r1_o;
    ((global::java.util.regex.CharClass_213) _r0_o)._fval_2clazz = (global::java.util.regex.AbstractCharClass) _r2_o;
    ((global::java.util.regex.AbstractCharClass) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.regex.CharClass$13: void <init>(java.util.regex.CharClass, java.util.regex.AbstractCharClass)]
}

public override bool contains(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.CharClass$13: boolean contains(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::java.util.regex.CharClass_213) _r1_o)._fval_2clazz;
    _r0.i = ((global::java.util.regex.AbstractCharClass) _r0_o).contains((int) _r2.i) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.regex.CharClass$13: boolean contains(int)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.CharClass$13]
//XMLVM_END_WRAPPER[java.util.regex.CharClass$13]

} // end of class: CharClass_213

} // end of namespace: java.util.regex
