// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.services {
public class ImageDownloadService_25: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.Image _fval_2i;

public global::com.codename1.ui.geom.Dimension _fval_2pref;

public global::com.codename1.io.services.ImageDownloadService _fthis_20;

public void @this(global::com.codename1.io.services.ImageDownloadService n1, global::com.codename1.ui.Image n2, global::com.codename1.ui.geom.Dimension n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$5: void <init>(com.codename1.io.services.ImageDownloadService, com.codename1.ui.Image, com.codename1.ui.geom.Dimension)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::com.codename1.io.services.ImageDownloadService_25) _r0_o)._fthis_20 = (global::com.codename1.io.services.ImageDownloadService) _r1_o;
    ((global::com.codename1.io.services.ImageDownloadService_25) _r0_o)._fval_2i = (global::com.codename1.ui.Image) _r2_o;
    ((global::com.codename1.io.services.ImageDownloadService_25) _r0_o)._fval_2pref = (global::com.codename1.ui.geom.Dimension) _r3_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$5: void <init>(com.codename1.io.services.ImageDownloadService, com.codename1.ui.Image, com.codename1.ui.geom.Dimension)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$5: void run()]
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
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fthis_20;
    _r1.i = ((global::com.codename1.io.services.ImageDownloadService) _r1_o).isDownloadToStyles() ? 1 : 0;
    if (_r1.i == 0) goto label101;
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fthis_20;
    _r1_o = global::com.codename1.io.services.ImageDownloadService.access_2300((global::com.codename1.io.services.ImageDownloadService) _r1_o);
    _r1_o = ((global::com.codename1.ui.Label) _r1_o).getUnselectedStyle();
    _r2_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fval_2i;
    ((global::com.codename1.ui.plaf.Style) _r1_o).setBgImage((global::com.codename1.ui.Image) _r2_o);
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fthis_20;
    _r1_o = global::com.codename1.io.services.ImageDownloadService.access_2300((global::com.codename1.io.services.ImageDownloadService) _r1_o);
    _r1_o = ((global::com.codename1.ui.Label) _r1_o).getSelectedStyle();
    _r2_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fval_2i;
    ((global::com.codename1.ui.plaf.Style) _r1_o).setBgImage((global::com.codename1.ui.Image) _r2_o);
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fthis_20;
    _r1_o = global::com.codename1.io.services.ImageDownloadService.access_2300((global::com.codename1.io.services.ImageDownloadService) _r1_o);
    _r1_o = ((global::com.codename1.ui.Label) _r1_o).getPressedStyle();
    _r2_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fval_2i;
    ((global::com.codename1.ui.plaf.Style) _r1_o).setBgImage((global::com.codename1.ui.Image) _r2_o);
    label53:;
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fthis_20;
    _r1_o = global::com.codename1.io.services.ImageDownloadService.access_2300((global::com.codename1.io.services.ImageDownloadService) _r1_o);
    _r0_o = ((global::com.codename1.ui.Label) _r1_o).getPreferredSize();
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fval_2pref;
    _r1.i = ((global::com.codename1.ui.geom.Dimension) _r1_o).getWidth();
    _r2.i = ((global::com.codename1.ui.geom.Dimension) _r0_o).getWidth();
    if (_r1.i != _r2.i) goto label87;
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fval_2pref;
    _r1.i = ((global::com.codename1.ui.geom.Dimension) _r1_o).getHeight();
    _r2.i = ((global::com.codename1.ui.geom.Dimension) _r0_o).getHeight();
    if (_r1.i == _r2.i) goto label100;
    label87:;
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fthis_20;
    _r1_o = global::com.codename1.io.services.ImageDownloadService.access_2300((global::com.codename1.io.services.ImageDownloadService) _r1_o);
    _r1_o = ((global::com.codename1.ui.Label) _r1_o).getComponentForm();
    ((global::com.codename1.ui.Form) _r1_o).revalidate();
    label100:;
    return;
    label101:;
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fthis_20;
    _r1_o = global::com.codename1.io.services.ImageDownloadService.access_2300((global::com.codename1.io.services.ImageDownloadService) _r1_o);
    _r2_o = ((global::com.codename1.io.services.ImageDownloadService_25) _r3_o)._fval_2i;
    ((global::com.codename1.ui.Label) _r1_o).setIcon((global::com.codename1.ui.Image) _r2_o);
    goto label53;
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$5: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$5]
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$5]

} // end of class: ImageDownloadService_25

} // end of namespace: com.codename1.io.services
