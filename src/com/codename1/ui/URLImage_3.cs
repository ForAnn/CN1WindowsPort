// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class URLImage_23: global::java.lang.Object,global::com.codename1.ui.URLImage_2ImageAdapter {
public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.URLImage$3: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.URLImage$3: void <init>()]
}

public virtual global::System.Object adaptImage(global::com.codename1.ui.EncodedImage n1, global::com.codename1.ui.EncodedImage n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.URLImage$3: com.codename1.ui.EncodedImage adaptImage(com.codename1.ui.EncodedImage, com.codename1.ui.EncodedImage)]
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
    global::org.xmlvm._nElement _r14;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r13_o = this;
    _r14_o = n1;
    _r15_o = n2;
    _r2.i = 0;
    _r5.i = 1;
    _r3.i = ((global::com.codename1.ui.EncodedImage) _r14_o).getWidth();
    _r4.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getWidth();
    if (_r3.i != _r4.i) goto label22;
    _r3.i = ((global::com.codename1.ui.EncodedImage) _r14_o).getHeight();
    _r4.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getHeight();
    if (_r3.i == _r4.i) goto label131;
    label22:;
    _r3_o = ((global::com.codename1.ui.EncodedImage) _r14_o).getInternal();
    _r4.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getWidth();
    _r6.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getHeight();
    _r0_o = ((global::com.codename1.ui.Image) _r3_o).scaledLargerRatio((int) _r4.i, (int) _r6.i);
    _r3.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r4.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getWidth();
    if (_r3.i <= _r4.i) goto label77;
    _r3.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r4.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getWidth();
    _r12.i = _r3.i - _r4.i;
    _r1.i = _r12.i / 2;
    _r3.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getWidth();
    _r4.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getHeight();
    _r0_o = ((global::com.codename1.ui.Image) _r0_o).subImage((int) _r1.i, (int) _r2.i, (int) _r3.i, (int) _r4.i, 0!=_r5.i);
    label72:;
    _r2_o = global::com.codename1.ui.EncodedImage.createFromImage((global::com.codename1.ui.Image) _r0_o, 0!=_r5.i);
    label76:;
    return (global::com.codename1.ui.EncodedImage) _r2_o;
    label77:;
    _r3.i = ((global::com.codename1.ui.Image) _r0_o).getHeight();
    _r4.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getHeight();
    if (_r3.i <= _r4.i) goto label72;
    _r3.i = ((global::com.codename1.ui.Image) _r0_o).getHeight();
    _r4.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getHeight();
    _r12.i = _r3.i - _r4.i;
    _r8.i = _r12.i / 2;
    _r3.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getWidth();
    _r4.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r9.i = global::java.lang.Math.min((int) _r3.i, (int) _r4.i);
    _r3.i = ((global::com.codename1.ui.EncodedImage) _r15_o).getHeight();
    _r4.i = ((global::com.codename1.ui.Image) _r0_o).getHeight();
    _r10.i = global::java.lang.Math.min((int) _r3.i, (int) _r4.i);
    _r6_o = _r0_o;
    _r7.i = _r2.i;
    _r11.i = _r5.i;
    _r0_o = ((global::com.codename1.ui.Image) _r6_o).subImage((int) _r7.i, (int) _r8.i, (int) _r9.i, (int) _r10.i, 0!=_r11.i);
    goto label72;
    label131:;
    _r2_o = _r14_o;
    goto label76;
//XMLVM_END_WRAPPER[com.codename1.ui.URLImage$3: com.codename1.ui.EncodedImage adaptImage(com.codename1.ui.EncodedImage, com.codename1.ui.EncodedImage)]
}

public virtual bool isAsyncAdapter(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.URLImage$3: boolean isAsyncAdapter()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.URLImage$3: boolean isAsyncAdapter()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.URLImage$3]
//XMLVM_END_WRAPPER[com.codename1.ui.URLImage$3]

} // end of class: URLImage_23

} // end of namespace: com.codename1.ui
