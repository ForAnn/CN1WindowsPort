// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.util.regex {
public class REProgram: global::java.lang.Object {
public static int _fOPT_1HASBACKREFS = 1;

public static int _fOPT_1HASBOL = 2;

public global::org.xmlvm._nArrayAdapter<char> _finstruction;

public int _flenInstruction;

public global::org.xmlvm._nArrayAdapter<char> _fprefix;

public int _fflags;

public int _fmaxParens;

public void @this(global::org.xmlvm._nArrayAdapter<char> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REProgram: void <init>(char[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    ((global::com.codename1.util.regex.REProgram) _r1_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r2_o, (int) _r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.util.regex.REProgram: void <init>(char[])]
}

public void @this(int n1, global::org.xmlvm._nArrayAdapter<char> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REProgram: void <init>(int, char[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r0.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    ((global::com.codename1.util.regex.REProgram) _r1_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r3_o, (int) _r0.i);
    ((global::com.codename1.util.regex.REProgram) _r1_o)._fmaxParens = _r2.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.util.regex.REProgram: void <init>(int, char[])]
}

public void @this(global::org.xmlvm._nArrayAdapter<char> n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REProgram: void <init>(char[], int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = -1;
    ((global::com.codename1.util.regex.REProgram) _r1_o)._fmaxParens = _r0.i;
    ((global::com.codename1.util.regex.REProgram) _r1_o).setInstructions((global::org.xmlvm._nArrayAdapter<char>) _r2_o, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.util.regex.REProgram: void <init>(char[], int)]
}

public virtual global::System.Object getInstructions(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REProgram: char[] getInstructions()]
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
    _r4_o = this;
    _r3.i = 0;
    _r1.i = ((global::com.codename1.util.regex.REProgram) _r4_o)._flenInstruction;
    if (_r1.i == 0) goto label18;
    _r1.i = ((global::com.codename1.util.regex.REProgram) _r4_o)._flenInstruction;
    _r0_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r1.i]);
    _r1_o = ((global::com.codename1.util.regex.REProgram) _r4_o)._finstruction;
    _r2.i = ((global::com.codename1.util.regex.REProgram) _r4_o)._flenInstruction;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r3.i, (global::java.lang.Object) _r0_o, (int) _r3.i, (int) _r2.i);
    _r1_o = _r0_o;
    label17:;
    return (global::org.xmlvm._nArrayAdapter<char>) _r1_o;
    label18:;
    _r1_o = null;
    goto label17;
//XMLVM_END_WRAPPER[com.codename1.util.regex.REProgram: char[] getInstructions()]
}

public virtual void setInstructions(global::org.xmlvm._nArrayAdapter<char> n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REProgram: void setInstructions(char[], int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r9_o = this;
    _r10_o = n1;
    _r11.i = n2;
    _r8.i = 6;
    _r7.i = 3;
    _r6.i = 0;
    ((global::com.codename1.util.regex.REProgram) _r9_o)._finstruction = (global::org.xmlvm._nArrayAdapter<char>) _r10_o;
    ((global::com.codename1.util.regex.REProgram) _r9_o)._flenInstruction = _r11.i;
    ((global::com.codename1.util.regex.REProgram) _r9_o)._fflags = _r6.i;
    _r4_o = null;
    ((global::com.codename1.util.regex.REProgram) _r9_o)._fprefix = (global::org.xmlvm._nArrayAdapter<char>) _r4_o;
    if (_r10_o == null) goto label100;
    if (_r11.i == 0) goto label100;
    if (_r11.i < _r7.i) goto label56;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<char>) _r10_o)[_r6.i];
    _r5.i = 124;
    if (_r4.i != _r5.i) goto label56;
    _r4.i = 2;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<char>) _r10_o)[_r4.i];
    _r2.i = (_r4.i << 16) >> 16;
    _r4.i = _r2.i + 0;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<char>) _r10_o)[_r4.i];
    _r5.i = 69;
    if (_r4.i != _r5.i) goto label56;
    if (_r11.i < _r8.i) goto label56;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<char>) _r10_o)[_r7.i];
    _r4.i = 65;
    if (_r3.i != _r4.i) goto label69;
    _r4.i = 4;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<char>) _r10_o)[_r4.i];
    _r4_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r1.i]);
    ((global::com.codename1.util.regex.REProgram) _r9_o)._fprefix = (global::org.xmlvm._nArrayAdapter<char>) _r4_o;
    _r4_o = ((global::com.codename1.util.regex.REProgram) _r9_o)._fprefix;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r10_o, (int) _r8.i, (global::java.lang.Object) _r4_o, (int) _r6.i, (int) _r1.i);
    label56:;
    _r0.i = 0;
    label57:;
    if (_r0.i >= _r11.i) goto label100;
    _r4.i = _r0.i + 0;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<char>) _r10_o)[_r4.i];
    switch (_r4.i) {
    case 35: goto label94;
    case 65: goto label88;
    case 91: goto label80;
    }
    label66:;
    _r0.i = _r0.i + 3;
    goto label57;
    label69:;
    _r4.i = 94;
    if (_r3.i != _r4.i) goto label56;
    _r4.i = ((global::com.codename1.util.regex.REProgram) _r9_o)._fflags;
    _r4.i = _r4.i | 2;
    ((global::com.codename1.util.regex.REProgram) _r9_o)._fflags = _r4.i;
    goto label56;
    label80:;
    _r4.i = _r0.i + 1;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<char>) _r10_o)[_r4.i];
    _r4.i = _r4.i * 2;
    _r0.i = _r0.i + _r4.i;
    goto label66;
    label88:;
    _r4.i = _r0.i + 1;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<char>) _r10_o)[_r4.i];
    _r0.i = _r0.i + _r4.i;
    goto label66;
    label94:;
    _r4.i = ((global::com.codename1.util.regex.REProgram) _r9_o)._fflags;
    _r4.i = _r4.i | 1;
    ((global::com.codename1.util.regex.REProgram) _r9_o)._fflags = _r4.i;
    label100:;
    return;
    label102:;
//XMLVM_END_WRAPPER[com.codename1.util.regex.REProgram: void setInstructions(char[], int)]
}

public virtual global::System.Object getPrefix(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REProgram: char[] getPrefix()]
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
    _r4_o = this;
    _r3.i = 0;
    _r1_o = ((global::com.codename1.util.regex.REProgram) _r4_o)._fprefix;
    if (_r1_o == null) goto label20;
    _r1_o = ((global::com.codename1.util.regex.REProgram) _r4_o)._fprefix;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r0_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r1.i]);
    _r1_o = ((global::com.codename1.util.regex.REProgram) _r4_o)._fprefix;
    _r2_o = ((global::com.codename1.util.regex.REProgram) _r4_o)._fprefix;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r3.i, (global::java.lang.Object) _r0_o, (int) _r3.i, (int) _r2.i);
    _r1_o = _r0_o;
    label19:;
    return (global::org.xmlvm._nArrayAdapter<char>) _r1_o;
    label20:;
    _r1_o = null;
    goto label19;
//XMLVM_END_WRAPPER[com.codename1.util.regex.REProgram: char[] getPrefix()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.REProgram]
//XMLVM_END_WRAPPER[com.codename1.util.regex.REProgram]

} // end of class: REProgram

} // end of namespace: com.codename1.util.regex
