// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.processing {
public class EvaluatorFactory: global::java.lang.Object {
public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.EvaluatorFactory: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.EvaluatorFactory: void <init>()]
}

public static global::System.Object createEvaluator(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.EvaluatorFactory: com.codename1.processing.Evaluator createEvaluator(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = n1;
    _r1.i = -1;
    // Value=@
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)64))}));
    _r0.i = global::com.codename1.processing.EvaluatorFactory.isNumeric((global::java.lang.String) _r3_o) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r0_o = new global::com.codename1.processing.IndexEvaluator();
    ((global::com.codename1.processing.IndexEvaluator) _r0_o).@this((global::java.lang.String) _r3_o);
    label14:;
    return (global::com.codename1.processing.Evaluator) _r0_o;
    label15:;
    // Value=@
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)64))}));
    _r0.i = ((global::java.lang.String) _r3_o).startsWith((global::java.lang.String) _r2_o) ? 1 : 0;
    if (_r0.i == 0) goto label29;
    _r0_o = new global::com.codename1.processing.AttributeEvaluator();
    ((global::com.codename1.processing.AttributeEvaluator) _r0_o).@this((global::java.lang.String) _r3_o);
    goto label14;
    label29:;
    _r0_o = global::com.codename1.processing.IndexEvaluator._fFUNC_1LAST;
    _r0.i = ((global::java.lang.String) _r3_o).indexOf((global::java.lang.String) _r0_o);
    if (_r0.i == _r1.i) goto label43;
    _r0_o = new global::com.codename1.processing.IndexEvaluator();
    ((global::com.codename1.processing.IndexEvaluator) _r0_o).@this((global::java.lang.String) _r3_o);
    goto label14;
    label43:;
    // Value=text()
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 40)), unchecked((char) unchecked((uint) 41))}));
    _r0.i = ((global::java.lang.String) _r3_o).indexOf((global::java.lang.String) _r0_o);
    if (_r0.i == _r1.i) goto label57;
    _r0_o = new global::com.codename1.processing.TextEvaluator();
    ((global::com.codename1.processing.TextEvaluator) _r0_o).@this((global::java.lang.String) _r3_o);
    goto label14;
    label57:;
    _r0_o = global::com.codename1.processing.IndexEvaluator._fFUNC_1POSITION;
    _r0.i = ((global::java.lang.String) _r3_o).indexOf((global::java.lang.String) _r0_o);
    if (_r0.i == _r1.i) goto label71;
    _r0_o = new global::com.codename1.processing.IndexEvaluator();
    ((global::com.codename1.processing.IndexEvaluator) _r0_o).@this((global::java.lang.String) _r3_o);
    goto label14;
    label71:;
    // Value=@
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)64))}));
    _r0.i = ((global::java.lang.String) _r3_o).startsWith((global::java.lang.String) _r2_o) ? 1 : 0;
    if (_r0.i == 0) goto label85;
    _r0_o = new global::com.codename1.processing.AttributeEvaluator();
    ((global::com.codename1.processing.AttributeEvaluator) _r0_o).@this((global::java.lang.String) _r3_o);
    goto label14;
    label85:;
    _r0.i = 37;
    _r0.i = ((global::java.lang.String) _r3_o).indexOf((int) _r0.i);
    if (_r0.i == _r1.i) goto label99;
    _r0_o = new global::com.codename1.processing.ContainsEvaluator();
    ((global::com.codename1.processing.ContainsEvaluator) _r0_o).@this((global::java.lang.String) _r3_o);
    goto label14;
    label99:;
    _r0.i = 61;
    _r0.i = ((global::java.lang.String) _r3_o).indexOf((int) _r0.i);
    if (_r0.i == _r1.i) goto label113;
    _r0_o = new global::com.codename1.processing.TextEvaluator();
    ((global::com.codename1.processing.TextEvaluator) _r0_o).@this((global::java.lang.String) _r3_o);
    goto label14;
    label113:;
    _r0_o = new global::java.lang.IllegalStateException();
    _r1_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r1_o).@this();
    // Value=Could not create a comparator for value: 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r3_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::java.lang.IllegalStateException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.processing.EvaluatorFactory: com.codename1.processing.Evaluator createEvaluator(java.lang.String)]
}

private static bool isNumeric(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.EvaluatorFactory: boolean isNumeric(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r2_o = ((global::java.lang.String) _r2_o).trim();
    _r0.i = 0;
    label5:;
    _r1.i = ((global::java.lang.String) _r2_o).length();
    if (_r0.i >= _r1.i) goto label26;
    _r1.i = ((global::java.lang.String) _r2_o).charAt((int) _r0.i);
    _r1.i = global::java.lang.Character.isDigit((char) _r1.i) ? 1 : 0;
    if (_r1.i != 0) goto label23;
    _r1.i = 0;
    label22:;
    return _r1.i!=0;
    label23:;
    _r0.i = _r0.i + 1;
    goto label5;
    label26:;
    _r1.i = 1;
    goto label22;
//XMLVM_END_WRAPPER[com.codename1.processing.EvaluatorFactory: boolean isNumeric(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.processing.EvaluatorFactory]
//XMLVM_END_WRAPPER[com.codename1.processing.EvaluatorFactory]

} // end of class: EvaluatorFactory

} // end of namespace: com.codename1.processing
