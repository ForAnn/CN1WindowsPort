// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.services {
public class ImageDownloadService_26: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.Image _fval_2i;

public global::com.codename1.io.services.ImageDownloadService _fthis_20;

public void @this(global::com.codename1.io.services.ImageDownloadService n1, global::com.codename1.ui.Image n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$6: void <init>(com.codename1.io.services.ImageDownloadService, com.codename1.ui.Image)]
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
    ((global::com.codename1.io.services.ImageDownloadService_26) _r0_o)._fthis_20 = (global::com.codename1.io.services.ImageDownloadService) _r1_o;
    ((global::com.codename1.io.services.ImageDownloadService_26) _r0_o)._fval_2i = (global::com.codename1.ui.Image) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$6: void <init>(com.codename1.io.services.ImageDownloadService, com.codename1.ui.Image)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$6: void run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.io.services.ImageDownloadService_26) _r2_o)._fthis_20;
    _r0.i = ((global::com.codename1.io.services.ImageDownloadService) _r0_o).isDownloadToStyles() ? 1 : 0;
    if (_r0.i == 0) goto label54;
    _r0_o = ((global::com.codename1.io.services.ImageDownloadService_26) _r2_o)._fthis_20;
    _r0_o = global::com.codename1.io.services.ImageDownloadService.access_2300((global::com.codename1.io.services.ImageDownloadService) _r0_o);
    _r0_o = ((global::com.codename1.ui.Label) _r0_o).getUnselectedStyle();
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_26) _r2_o)._fval_2i;
    ((global::com.codename1.ui.plaf.Style) _r0_o).setBgImage((global::com.codename1.ui.Image) _r1_o);
    _r0_o = ((global::com.codename1.io.services.ImageDownloadService_26) _r2_o)._fthis_20;
    _r0_o = global::com.codename1.io.services.ImageDownloadService.access_2300((global::com.codename1.io.services.ImageDownloadService) _r0_o);
    _r0_o = ((global::com.codename1.ui.Label) _r0_o).getSelectedStyle();
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_26) _r2_o)._fval_2i;
    ((global::com.codename1.ui.plaf.Style) _r0_o).setBgImage((global::com.codename1.ui.Image) _r1_o);
    _r0_o = ((global::com.codename1.io.services.ImageDownloadService_26) _r2_o)._fthis_20;
    _r0_o = global::com.codename1.io.services.ImageDownloadService.access_2300((global::com.codename1.io.services.ImageDownloadService) _r0_o);
    _r0_o = ((global::com.codename1.ui.Label) _r0_o).getPressedStyle();
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_26) _r2_o)._fval_2i;
    ((global::com.codename1.ui.plaf.Style) _r0_o).setBgImage((global::com.codename1.ui.Image) _r1_o);
    label53:;
    return;
    label54:;
    _r0_o = ((global::com.codename1.io.services.ImageDownloadService_26) _r2_o)._fthis_20;
    _r0_o = global::com.codename1.io.services.ImageDownloadService.access_2300((global::com.codename1.io.services.ImageDownloadService) _r0_o);
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_26) _r2_o)._fval_2i;
    ((global::com.codename1.ui.Label) _r0_o).setIcon((global::com.codename1.ui.Image) _r1_o);
    goto label53;
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$6: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$6]
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$6]

} // end of class: ImageDownloadService_26

} // end of namespace: com.codename1.io.services
