// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.net {
public abstract class _iSocketOptions {
public static int _fSO_1LINGER = 128;

public static int _fSO_1TIMEOUT = 4102;

public static int _fTCP_1NODELAY = 1;

public static int _fIP_1MULTICAST_1IF = 16;

public static int _fSO_1BINDADDR = 15;

public static int _fSO_1REUSEADDR = 4;

public static int _fSO_1SNDBUF = 4097;

public static int _fSO_1RCVBUF = 4098;

public static int _fSO_1KEEPALIVE = 8;

public static int _fIP_1TOS = 3;

public static int _fIP_1MULTICAST_1LOOP = 18;

public static int _fSO_1BROADCAST = 32;

public static int _fSO_1OOBINLINE = 4099;

public static int _fIP_1MULTICAST_1IF2 = 31;


} // end of abstract class: _iSocketOptions

public interface SocketOptions {
 global::System.Object getOption(int n1);

 void setOption(int n1, global::java.lang.Object n2);

//XMLVM_BEGIN_WRAPPER[java.net.SocketOptions]
//XMLVM_END_WRAPPER[java.net.SocketOptions]

} // end of interface: SocketOptions

} // end of namespace: java.net
