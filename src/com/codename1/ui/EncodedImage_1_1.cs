// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class EncodedImage_21_21: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.Image _fval_2i;

public global::com.codename1.ui.EncodedImage_21 _fthis_21;

public void @this(global::com.codename1.ui.EncodedImage_21 n1, global::com.codename1.ui.Image n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.EncodedImage$1$1: void <init>(com.codename1.ui.EncodedImage$1, com.codename1.ui.Image)]
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
    ((global::com.codename1.ui.EncodedImage_21_21) _r0_o)._fthis_21 = (global::com.codename1.ui.EncodedImage_21) _r1_o;
    ((global::com.codename1.ui.EncodedImage_21_21) _r0_o)._fval_2i = (global::com.codename1.ui.Image) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.EncodedImage$1$1: void <init>(com.codename1.ui.EncodedImage$1, com.codename1.ui.Image)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.EncodedImage$1$1: void run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0_o = ((global::com.codename1.ui.EncodedImage_21_21) _r3_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.EncodedImage_21) _r0_o)._fthis_20;
    _r0.i = global::com.codename1.ui.EncodedImage.access_2200((global::com.codename1.ui.EncodedImage) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label19;
    _r0_o = ((global::com.codename1.ui.EncodedImage_21_21) _r3_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.EncodedImage_21) _r0_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.EncodedImage_21_21) _r3_o)._fval_2i;
    global::com.codename1.ui.EncodedImage.access_2302((global::com.codename1.ui.EncodedImage) _r0_o, (global::com.codename1.ui.Image) _r1_o);
    label19:;
    _r0_o = ((global::com.codename1.ui.EncodedImage_21_21) _r3_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.EncodedImage_21) _r0_o)._fthis_20;
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r2_o = ((global::com.codename1.ui.EncodedImage_21_21) _r3_o)._fval_2i;
    _r1_o = ((global::com.codename1.ui.Display) _r1_o).createSoftWeakRef((global::java.lang.Object) _r2_o);
    global::com.codename1.ui.EncodedImage.access_2402((global::com.codename1.ui.EncodedImage) _r0_o, (global::java.lang.Object) _r1_o);
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).getCurrent();
    ((global::com.codename1.ui.Form) _r0_o).repaint();
    _r0_o = ((global::com.codename1.ui.EncodedImage_21_21) _r3_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.EncodedImage_21) _r0_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.EncodedImage_21_21) _r3_o)._fval_2i;
    _r1.i = ((global::com.codename1.ui.Image) _r1_o).getWidth();
    global::com.codename1.ui.EncodedImage.access_2502((global::com.codename1.ui.EncodedImage) _r0_o, (int) _r1.i);
    _r0_o = ((global::com.codename1.ui.EncodedImage_21_21) _r3_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.EncodedImage_21) _r0_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.EncodedImage_21_21) _r3_o)._fval_2i;
    _r1.i = ((global::com.codename1.ui.Image) _r1_o).getHeight();
    global::com.codename1.ui.EncodedImage.access_2602((global::com.codename1.ui.EncodedImage) _r0_o, (int) _r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.EncodedImage$1$1: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.EncodedImage$1$1]
//XMLVM_END_WRAPPER[com.codename1.ui.EncodedImage$1$1]

} // end of class: EncodedImage_21_21

} // end of namespace: com.codename1.ui
