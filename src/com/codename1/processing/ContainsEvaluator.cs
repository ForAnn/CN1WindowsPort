// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.processing {
public class ContainsEvaluator: global::com.codename1.processing.AbstractEvaluator {
public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.ContainsEvaluator: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.processing.AbstractEvaluator) _r0_o).@this((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.ContainsEvaluator: void <init>(java.lang.String)]
}

private global::System.Object _1getLeftValue(global::com.codename1.processing.StructuredContent n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.ContainsEvaluator: java.lang.String[] _getLeftValue(com.codename1.processing.StructuredContent, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r3.i = 0;
    _r0_o = ((global::com.codename1.processing.StructuredContent) _r5_o).getChild((int) _r3.i);
    _r1_o = global::com.codename1.processing.Result.fromContent((global::com.codename1.processing.StructuredContent) _r0_o);
    _r2_o = ((global::com.codename1.processing.Result) _r1_o).getAsStringArray((global::java.lang.String) _r6_o);
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.processing.ContainsEvaluator: java.lang.String[] _getLeftValue(com.codename1.processing.StructuredContent, java.lang.String)]
}

public override global::System.Object evaluateLeftContainsRight(global::com.codename1.processing.StructuredContent n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.ContainsEvaluator: java.lang.Object evaluateLeftContainsRight(com.codename1.processing.StructuredContent, java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = this;
    _r11_o = n1;
    _r12_o = n2;
    _r13_o = n3;
    _r9_o = null;
    _r8.i = 0;
    _r7.i = -1;
    _r2_o = ((global::com.codename1.processing.ContainsEvaluator) _r10_o)._1getLeftValue((global::com.codename1.processing.StructuredContent) _r11_o, (global::java.lang.String) _r12_o);
    if (_r2_o != null) goto label11;
    _r5_o = _r9_o;
    label10:;
    return (global::java.lang.Object) _r5_o;
    label11:;
    // Value=(
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)40))}));
    _r5.i = ((global::java.lang.String) _r13_o).indexOf((global::java.lang.String) _r5_o);
    if (_r5.i != _r7.i) goto label41;
    _r5.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r6.i = 1;
    if (_r5.i != _r6.i) goto label41;
    _r5_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r8.i];
    _r5_o = ((global::java.lang.String) _r5_o).toLowerCase();
    _r6_o = ((global::java.lang.String) _r13_o).toLowerCase();
    _r5.i = ((global::java.lang.String) _r5_o).indexOf((global::java.lang.String) _r6_o);
    if (_r5.i == _r7.i) goto label41;
    _r5_o = _r11_o;
    goto label10;
    label41:;
    _r4_o = ((global::com.codename1.processing.ContainsEvaluator) _r10_o).explode((global::java.lang.String) _r13_o);
    _r5.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    _r6.i = _r8.i;
    label47:;
    if (_r6.i >= _r5.i) goto label74;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r6.i];
    _r0.i = 0;
    label52:;
    _r7.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    if (_r0.i >= _r7.i) goto label63;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r0.i];
    _r7.i = ((global::java.lang.String) _r1_o).equalsIgnoreCase((global::java.lang.String) _r3_o) ? 1 : 0;
    if (_r7.i == 0) goto label68;
    label63:;
    _r7.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    if (_r0.i != _r7.i) goto label71;
    _r5_o = _r9_o;
    goto label10;
    label68:;
    _r0.i = _r0.i + 1;
    goto label52;
    label71:;
    _r6.i = _r6.i + 1;
    goto label47;
    label74:;
    _r5_o = _r11_o;
    goto label10;
//XMLVM_END_WRAPPER[com.codename1.processing.ContainsEvaluator: java.lang.Object evaluateLeftContainsRight(com.codename1.processing.StructuredContent, java.lang.String, java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.processing.ContainsEvaluator]
//XMLVM_END_WRAPPER[com.codename1.processing.ContainsEvaluator]

} // end of class: ContainsEvaluator

} // end of namespace: com.codename1.processing
