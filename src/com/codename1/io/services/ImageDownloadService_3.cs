// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.services {
public class ImageDownloadService_23: global::java.lang.Object,global::java.lang.Runnable {
public global::java.lang.String _fval_2url;

public global::com.codename1.ui.Label _fval_2l;

public global::java.lang.String _fval_2cacheId;

public bool _fval_2keep;

public global::com.codename1.ui.geom.Dimension _fval_2toScale;

public sbyte _fval_2priority;

public global::com.codename1.ui.Image _fval_2placeholder;

public bool _fval_2maintainAspectRatio;

public void @this(global::java.lang.String n1, global::com.codename1.ui.Label n2, global::java.lang.String n3, bool n4, global::com.codename1.ui.geom.Dimension n5, sbyte n6, global::com.codename1.ui.Image n7, bool n8){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$3: void <init>(java.lang.String, com.codename1.ui.Label, java.lang.String, boolean, com.codename1.ui.geom.Dimension, byte, com.codename1.ui.Image, boolean)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    _r4.i = n4 ? 1 : 0;
    _r5_o = n5;
    _r6.i = n6;
    _r7_o = n7;
    _r8.i = n8 ? 1 : 0;
    ((global::com.codename1.io.services.ImageDownloadService_23) _r0_o)._fval_2url = (global::java.lang.String) _r1_o;
    ((global::com.codename1.io.services.ImageDownloadService_23) _r0_o)._fval_2l = (global::com.codename1.ui.Label) _r2_o;
    ((global::com.codename1.io.services.ImageDownloadService_23) _r0_o)._fval_2cacheId = (global::java.lang.String) _r3_o;
    ((global::com.codename1.io.services.ImageDownloadService_23) _r0_o)._fval_2keep = 0!=_r4.i;
    ((global::com.codename1.io.services.ImageDownloadService_23) _r0_o)._fval_2toScale = (global::com.codename1.ui.geom.Dimension) _r5_o;
    ((global::com.codename1.io.services.ImageDownloadService_23) _r0_o)._fval_2priority = (sbyte) _r6.i;
    ((global::com.codename1.io.services.ImageDownloadService_23) _r0_o)._fval_2placeholder = (global::com.codename1.ui.Image) _r7_o;
    ((global::com.codename1.io.services.ImageDownloadService_23) _r0_o)._fval_2maintainAspectRatio = 0!=_r8.i;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$3: void <init>(java.lang.String, com.codename1.ui.Label, java.lang.String, boolean, com.codename1.ui.geom.Dimension, byte, com.codename1.ui.Image, boolean)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$3: void run()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = this;
    _r0_o = ((global::com.codename1.io.services.ImageDownloadService_23) _r8_o)._fval_2url;
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_23) _r8_o)._fval_2l;
    _r2_o = ((global::com.codename1.io.services.ImageDownloadService_23) _r8_o)._fval_2cacheId;
    _r3.i = ((global::com.codename1.io.services.ImageDownloadService_23) _r8_o)._fval_2keep ? 1 : 0;
    _r4_o = ((global::com.codename1.io.services.ImageDownloadService_23) _r8_o)._fval_2toScale;
    _r5.i = ((global::com.codename1.io.services.ImageDownloadService_23) _r8_o)._fval_2priority;
    _r6_o = ((global::com.codename1.io.services.ImageDownloadService_23) _r8_o)._fval_2placeholder;
    _r7.i = ((global::com.codename1.io.services.ImageDownloadService_23) _r8_o)._fval_2maintainAspectRatio ? 1 : 0;
    global::com.codename1.io.services.ImageDownloadService.access_2200((global::java.lang.String) _r0_o, (global::com.codename1.ui.Label) _r1_o, (global::java.lang.String) _r2_o, 0!=_r3.i, (global::com.codename1.ui.geom.Dimension) _r4_o, (sbyte) _r5.i, (global::com.codename1.ui.Image) _r6_o, 0!=_r7.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$3: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$3]
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$3]

} // end of class: ImageDownloadService_23

} // end of namespace: com.codename1.io.services
