// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class LayoutStyle: global::java.lang.Object {

static LayoutStyle() {
    @static();
}

public static int _fRELATED = 0;

public static int _fUNRELATED = 1;

public static int _fINDENT = 3;

private static global::com.codename1.ui.layouts.LayoutStyle _flayoutStyle;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: void <init>()]
}

public static void setSharedInstance(global::com.codename1.ui.layouts.LayoutStyle n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: void setSharedInstance(com.codename1.ui.layouts.LayoutStyle)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = n1;
    global::com.codename1.ui.layouts.LayoutStyle._flayoutStyle = (global::com.codename1.ui.layouts.LayoutStyle) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: void setSharedInstance(com.codename1.ui.layouts.LayoutStyle)]
}

public static global::System.Object getSharedInstance(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: com.codename1.ui.layouts.LayoutStyle getSharedInstance()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::com.codename1.ui.layouts.LayoutStyle._flayoutStyle;
    return (global::com.codename1.ui.layouts.LayoutStyle) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: com.codename1.ui.layouts.LayoutStyle getSharedInstance()]
}

public virtual int getPreferredGap(global::com.codename1.ui.Component n1, global::com.codename1.ui.Component n2, int n3, int n4, global::com.codename1.ui.Container n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getPreferredGap(com.codename1.ui.Component, com.codename1.ui.Component, int, int, com.codename1.ui.Container)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6_o = n1;
    _r7_o = n2;
    _r8.i = n3;
    _r9.i = n4;
    _r10_o = n5;
    _r4.i = 7;
    _r2.i = 3;
    _r3.i = 1;
    if (_r9.i == _r3.i) goto label20;
    _r1.i = 5;
    if (_r9.i == _r1.i) goto label20;
    if (_r9.i == _r4.i) goto label20;
    if (_r9.i == _r2.i) goto label20;
    _r1_o = new global::java.lang.IllegalArgumentException();
    // Value=Invalid position
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::java.lang.IllegalArgumentException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r1_o);
    label20:;
    if (_r6_o == null) goto label24;
    if (_r7_o != null) goto label32;
    label24:;
    _r1_o = new global::java.lang.IllegalArgumentException();
    // Value=Components must be non-null
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    ((global::java.lang.IllegalArgumentException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r1_o);
    label32:;
    if (_r8.i != 0) goto label43;
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r1.i = ((global::com.codename1.ui.Display) _r1_o).convertToPixels((int) _r3.i, 0!=_r3.i);
    label42:;
    return _r1.i;
    label43:;
    if (_r8.i != _r3.i) goto label55;
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r2.i = 2;
    _r1.i = ((global::com.codename1.ui.Display) _r1_o).convertToPixels((int) _r2.i, 0!=_r3.i);
    goto label42;
    label55:;
    if (_r8.i != _r2.i) goto label87;
    if (_r9.i == _r2.i) goto label61;
    if (_r9.i != _r4.i) goto label78;
    label61:;
    _r0.i = ((global::com.codename1.ui.layouts.LayoutStyle) _r5_o).getButtonChildIndent((global::com.codename1.ui.Component) _r6_o, (int) _r9.i);
    if (_r0.i == 0) goto label69;
    _r1.i = _r0.i;
    goto label42;
    label69:;
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r1.i = ((global::com.codename1.ui.Display) _r1_o).convertToPixels((int) _r3.i, 0!=_r3.i);
    goto label42;
    label78:;
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r1.i = ((global::com.codename1.ui.Display) _r1_o).convertToPixels((int) _r3.i, 0!=_r3.i);
    goto label42;
    label87:;
    _r1_o = new global::java.lang.IllegalArgumentException();
    // Value=Invalid type
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.lang.IllegalArgumentException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r1_o);
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getPreferredGap(com.codename1.ui.Component, com.codename1.ui.Component, int, int, com.codename1.ui.Container)]
}

public virtual int getContainerGap(global::com.codename1.ui.Component n1, int n2, global::com.codename1.ui.Container n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getContainerGap(com.codename1.ui.Component, int, com.codename1.ui.Container)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r6_o = n3;
    _r2.i = 1;
    if (_r5.i == _r2.i) goto label20;
    _r0.i = 5;
    if (_r5.i == _r0.i) goto label20;
    _r0.i = 7;
    if (_r5.i == _r0.i) goto label20;
    _r0.i = 3;
    if (_r5.i == _r0.i) goto label20;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=Invalid position
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label20:;
    if (_r4_o != null) goto label30;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=Component must be non-null
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label30:;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r1.i = 2;
    _r0.i = ((global::com.codename1.ui.Display) _r0_o).convertToPixels((int) _r1.i, 0!=_r2.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getContainerGap(com.codename1.ui.Component, int, com.codename1.ui.Container)]
}

public virtual int getCBRBPadding(global::com.codename1.ui.Component n1, global::com.codename1.ui.Component n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getCBRBPadding(com.codename1.ui.Component, com.codename1.ui.Component, int, int)]
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
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r0.i = ((global::com.codename1.ui.layouts.LayoutStyle) _r1_o).getCBRBPadding((global::com.codename1.ui.Component) _r2_o, (int) _r4.i);
    _r5.i = _r5.i - _r0.i;
    if (_r5.i <= 0) goto label16;
    _r0.i = ((global::com.codename1.ui.layouts.LayoutStyle) _r1_o).flipDirection((int) _r4.i);
    _r0.i = ((global::com.codename1.ui.layouts.LayoutStyle) _r1_o).getCBRBPadding((global::com.codename1.ui.Component) _r3_o, (int) _r0.i);
    _r5.i = _r5.i - _r0.i;
    label16:;
    if (_r5.i >= 0) goto label20;
    _r0.i = 0;
    label19:;
    return _r0.i;
    label20:;
    _r0.i = _r5.i;
    goto label19;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getCBRBPadding(com.codename1.ui.Component, com.codename1.ui.Component, int, int)]
}

public virtual int getCBRBPadding(global::com.codename1.ui.Component n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getCBRBPadding(com.codename1.ui.Component, int, int)]
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
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0.i = ((global::com.codename1.ui.layouts.LayoutStyle) _r1_o).getCBRBPadding((global::com.codename1.ui.Component) _r2_o, (int) _r3.i);
    _r4.i = _r4.i - _r0.i;
    _r0.i = 0;
    _r0.i = global::java.lang.Math.max((int) _r4.i, (int) _r0.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getCBRBPadding(com.codename1.ui.Component, int, int)]
}

public virtual int flipDirection(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int flipDirection(int)]
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
    _r3_o = this;
    _r4.i = n1;
    switch (_r4.i) {
    case 1: goto label28;
    case 3: goto label32;
    case 5: goto label30;
    case 7: goto label34;
    }
    _r0_o = new global::java.lang.IllegalArgumentException();
    _r1_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r1_o).@this();
    // Value=Illegal position: 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((int) _r4.i);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label28:;
    _r0.i = 5;
    label29:;
    return _r0.i;
    label30:;
    _r0.i = 1;
    goto label29;
    label32:;
    _r0.i = 7;
    goto label29;
    label34:;
    _r0.i = 3;
    goto label29;
    label36:;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int flipDirection(int)]
}

private int getCBRBPadding(global::com.codename1.ui.Component n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getCBRBPadding(com.codename1.ui.Component, int)]
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
    _r0.i = 0;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getCBRBPadding(com.codename1.ui.Component, int)]
}

private int getInset(global::com.codename1.ui.Component n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getInset(com.codename1.ui.Component, int)]
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
    _r7_o = this;
    _r8_o = n1;
    _r9.i = n2;
    _r6.i = 0;
    _r4_o = ((global::com.codename1.ui.Component) _r8_o).getStyle();
    _r5.i = 1;
    _r1.i = ((global::com.codename1.ui.plaf.Style) _r4_o).getMargin(0!=_r6.i, (int) _r5.i);
    _r4_o = ((global::com.codename1.ui.Component) _r8_o).getStyle();
    _r3.i = ((global::com.codename1.ui.plaf.Style) _r4_o).getMargin(0!=_r6.i, (int) _r6.i);
    _r4_o = ((global::com.codename1.ui.Component) _r8_o).getStyle();
    _r5.i = 3;
    _r2.i = ((global::com.codename1.ui.plaf.Style) _r4_o).getMargin(0!=_r6.i, (int) _r5.i);
    _r4_o = ((global::com.codename1.ui.Component) _r8_o).getStyle();
    _r5.i = 2;
    _r0.i = ((global::com.codename1.ui.plaf.Style) _r4_o).getMargin(0!=_r6.i, (int) _r5.i);
    switch (_r9.i) {
    case 1: goto label64;
    case 3: goto label68;
    case 5: goto label66;
    case 7: goto label70;
    }
    _r4_o = new global::java.lang.IllegalArgumentException();
    _r5_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r5_o).@this();
    // Value=Illegal argument position: 
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r6_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((int) _r9.i);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).toString();
    ((global::java.lang.IllegalArgumentException) _r4_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r4_o);
    label64:;
    _r4.i = _r3.i;
    label65:;
    return _r4.i;
    label66:;
    _r4.i = _r0.i;
    goto label65;
    label68:;
    _r4.i = _r2.i;
    goto label65;
    label70:;
    _r4.i = _r1.i;
    goto label65;
    label72:;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getInset(com.codename1.ui.Component, int)]
}

public virtual int getButtonChildIndent(global::com.codename1.ui.Component n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getButtonChildIndent(com.codename1.ui.Component, int)]
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
    _r0.i = 0;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: int getButtonChildIndent(com.codename1.ui.Component, int)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = new global::com.codename1.ui.layouts.LayoutStyle();
    ((global::com.codename1.ui.layouts.LayoutStyle) _r0_o).@this();
    global::com.codename1.ui.layouts.LayoutStyle._flayoutStyle = (global::com.codename1.ui.layouts.LayoutStyle) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayoutStyle]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayoutStyle]

} // end of class: LayoutStyle

} // end of namespace: com.codename1.ui.layouts
