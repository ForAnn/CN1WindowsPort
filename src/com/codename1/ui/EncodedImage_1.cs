// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class EncodedImage_21: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.EncodedImage _fthis_20;

public void @this(global::com.codename1.ui.EncodedImage n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.EncodedImage$1: void <init>(com.codename1.ui.EncodedImage)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.EncodedImage_21) _r0_o)._fthis_20 = (global::com.codename1.ui.EncodedImage) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.EncodedImage$1: void <init>(com.codename1.ui.EncodedImage)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.EncodedImage$1: void run()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    try {
    _r4_o = ((global::com.codename1.ui.EncodedImage_21) _r6_o)._fthis_20;
    _r0_o = ((global::com.codename1.ui.EncodedImage) _r4_o).getImageData();
    _r4.i = 0;
    _r5.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2_o = global::com.codename1.ui.Image.createImage((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r4.i, (int) _r5.i);
    _r4_o = ((global::com.codename1.ui.EncodedImage_21) _r6_o)._fthis_20;
    _r4.i = global::com.codename1.ui.EncodedImage.access_2000((global::com.codename1.ui.EncodedImage) _r4_o) ? 1 : 0;
    if (_r4.i == 0) goto label29;
    _r4_o = ((global::com.codename1.ui.EncodedImage_21) _r6_o)._fthis_20;
    _r4.i = global::com.codename1.ui.EncodedImage.access_2100((global::com.codename1.ui.EncodedImage) _r4_o) ? 1 : 0;
    ((global::com.codename1.ui.Image) _r2_o).setOpaque(0!=_r4.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label63;
        }
        throw ex;
    } // end catch
    label29:;
    try {
    _r4_o = global::com.codename1.ui.Display.getInstance();
    _r3_o = ((global::com.codename1.ui.Display) _r4_o).getImplementation();
    _r4_o = ((global::com.codename1.ui.Image) _r2_o).getImage();
    _r5_o = ((global::com.codename1.ui.EncodedImage_21) _r6_o)._fthis_20;
    _r5_o = ((global::com.codename1.ui.EncodedImage) _r5_o).getImageName();
    ((global::com.codename1.impl.CodenameOneImplementation) _r3_o).setImageName((global::java.lang.Object) _r4_o, (global::java.lang.String) _r5_o);
    _r4_o = global::com.codename1.ui.Display.getInstance();
    _r5_o = new global::com.codename1.ui.EncodedImage_21_21();
    ((global::com.codename1.ui.EncodedImage_21_21) _r5_o).@this((global::com.codename1.ui.EncodedImage_21) _r6_o, (global::com.codename1.ui.Image) _r2_o);
    ((global::com.codename1.ui.Display) _r4_o).callSerially((global::java.lang.Runnable) _r5_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label63;
        }
        throw ex;
    } // end catch
    label62:;
    return;
    label63:;
    _r4_o = _ex.getJavaException();
    _ex = null;
    _r1_o = _r4_o;
    ((global::java.lang.Exception) _r1_o).printStackTrace();
    goto label62;
//XMLVM_END_WRAPPER[com.codename1.ui.EncodedImage$1: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.EncodedImage$1]
//XMLVM_END_WRAPPER[com.codename1.ui.EncodedImage$1]

} // end of class: EncodedImage_21

} // end of namespace: com.codename1.ui
