// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class HTMLInputFormat_2FormatConstraint: global::java.lang.Object {
public static int _fTYPE_1LOWERCASE = 1;

public static int _fTYPE_1UPPERCASE = 2;

public static int _fTYPE_1NUMERIC = 4;

public static int _fTYPE_1SYMBOL = 8;

public static int _fTYPE_1ANY = 16;

public static int _fCOUNT_1EXACTLY_1ONE = -2147483648;

public static int _fCOUNT_1NO_1LIMIT = 2147483647;

public int _ftype;

public int _fcount;

public global::com.codename1.ui.html.HTMLInputFormat _fthis_20;

public void @this(global::com.codename1.ui.html.HTMLInputFormat n1, int n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLInputFormat$FormatConstraint: void <init>(com.codename1.ui.html.HTMLInputFormat, int, java.lang.String)]
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
    _r7_o = n3;
    ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r4_o)._fthis_20 = (global::com.codename1.ui.html.HTMLInputFormat) _r5_o;
    ((global::java.lang.Object) _r4_o).@this();
    // Value=*
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)42))}));
    _r1.i = ((global::java.lang.String) _r7_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label21;
    _r1.i = 2147483647;
    ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r4_o)._fcount = _r1.i;
    label18:;
    ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r4_o)._ftype = _r6.i;
    return;
    label21:;
    // Value=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r1.i = ((global::java.lang.String) _r7_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label34;
    _r1.i = -2147483648;
    ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r4_o)._fcount = _r1.i;
    goto label18;
    label34:;
    try {
    _r1.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r7_o);
    ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r4_o)._fcount = _r1.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NumberFormatException) {
            _ex = ex;
            goto label41;
        }
        throw ex;
    } // end catch
    goto label18;
    label41:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r1_o;
    _r1_o = global::java.lang.System._fout;
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    // Value=Invalid FormatConstraint count 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r7_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    ((global::java.io.PrintStream) _r1_o).println((global::java.lang.String) _r2_o);
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLInputFormat$FormatConstraint: void <init>(com.codename1.ui.html.HTMLInputFormat, int, java.lang.String)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLInputFormat$FormatConstraint: java.lang.String toString()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r9_o = this;
    _r8.i = -2147483648;
    // Value= 
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    // Value=
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r3.i = ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r9_o)._fcount;
    if (_r3.i != _r8.i) goto label151;
    label10:;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    // Value= 
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r7_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    // Value= 
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r7_o);
    _r4_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=html.format.or
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114))}));
    // Value=or
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)111)), unchecked((char) unchecked((uint) 114))}));
    _r4_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).localize((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    // Value= 
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r7_o);
    _r1_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r3.i = ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r9_o)._ftype;
    _r3.i = _r3.i & 16;
    if (_r3.i == 0) goto label232;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    // Value=any
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 121))}));
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    label93:;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    // Value= 
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r7_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    _r3.i = ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r9_o)._fcount;
    if (_r3.i == _r8.i) goto label389;
    _r3.i = ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r9_o)._fcount;
    _r4.i = 1;
    if (_r3.i == _r4.i) goto label389;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    _r4_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=html.format.chars
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115))}));
    // Value=characters
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 115))}));
    _r4_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).localize((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    label150:;
    return (global::java.lang.String) _r2_o;
    label151:;
    _r3.i = ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r9_o)._fcount;
    _r4.i = 2147483647;
    if (_r3.i != _r4.i) goto label189;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    _r4_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=html.format.anynumber
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    // Value=any number of
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 102))}));
    _r4_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).localize((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    goto label10;
    label189:;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    _r4_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=html.format.upto
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111))}));
    // Value=up to
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111))}));
    _r4_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).localize((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    // Value= 
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r7_o);
    _r4.i = ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r9_o)._fcount;
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((int) _r4.i);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    goto label10;
    label232:;
    _r3.i = ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r9_o)._ftype;
    _r3.i = _r3.i & 1;
    if (_r3.i == 0) goto label268;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    _r4_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=html.format.lowercase
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101))}));
    // Value=lowercase
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101))}));
    _r4_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).localize((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    _r0_o = _r1_o;
    label268:;
    _r3.i = ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r9_o)._ftype;
    _r3.i = _r3.i & 2;
    if (_r3.i == 0) goto label308;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r0_o);
    _r4_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=html.format.uppercase
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101))}));
    // Value=uppercase
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101))}));
    _r4_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).localize((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    _r0_o = _r1_o;
    label308:;
    _r3.i = ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r9_o)._ftype;
    _r3.i = _r3.i & 4;
    if (_r3.i == 0) goto label348;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r0_o);
    _r4_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=html.format.numeric
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99))}));
    // Value=numeric
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99))}));
    _r4_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).localize((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    _r0_o = _r1_o;
    label348:;
    _r3.i = ((global::com.codename1.ui.html.HTMLInputFormat_2FormatConstraint) _r9_o)._ftype;
    _r3.i = _r3.i & 8;
    if (_r3.i == 0) goto label93;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r0_o);
    _r4_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=html.format.symbol
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108))}));
    // Value=symbol
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108))}));
    _r4_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).localize((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    goto label93;
    label389:;
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    _r4_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=html.format.char
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114))}));
    // Value=character
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r4_o = ((global::com.codename1.ui.plaf.UIManager) _r4_o).localize((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r2_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    goto label150;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLInputFormat$FormatConstraint: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLInputFormat$FormatConstraint]
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLInputFormat$FormatConstraint]

} // end of class: HTMLInputFormat_2FormatConstraint

} // end of namespace: com.codename1.ui.html
