using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pushlink.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']"
	[global::Android.Runtime.Register ("com/pushlink/android/StatusBarStrategy", DoNotGenerateAcw=true)]
	public sealed partial class StatusBarStrategy : global::Com.Pushlink.Android.Strategy {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pushlink/android/StatusBarStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatusBarStrategy); }
		}

		internal StatusBarStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getHash;
		static IntPtr id_setHash_Ljava_lang_String_;
		protected override string Hash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='getHash' and count(parameter)=0]"
			[Register ("getHash", "()Ljava/lang/String;", "GetGetHashHandler")]
			get {
				if (id_getHash == IntPtr.Zero)
					id_getHash = JNIEnv.GetMethodID (class_ref, "getHash", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHash), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='setHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHash", "(Ljava/lang/String;)V", "GetSetHash_Ljava_lang_String_Handler")]
			set {
				if (id_setHash_Ljava_lang_String_ == IntPtr.Zero)
					id_setHash_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHash", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setHash_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getStatusBarDescription;
		static IntPtr id_setStatusBarDescription_Ljava_lang_String_;
		public string StatusBarDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='getStatusBarDescription' and count(parameter)=0]"
			[Register ("getStatusBarDescription", "()Ljava/lang/String;", "GetGetStatusBarDescriptionHandler")]
			get {
				if (id_getStatusBarDescription == IntPtr.Zero)
					id_getStatusBarDescription = JNIEnv.GetMethodID (class_ref, "getStatusBarDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStatusBarDescription), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='setStatusBarDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatusBarDescription", "(Ljava/lang/String;)V", "GetSetStatusBarDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setStatusBarDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatusBarDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatusBarDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setStatusBarDescription_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getStatusBarTitle;
		static IntPtr id_setStatusBarTitle_Ljava_lang_String_;
		public string StatusBarTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='getStatusBarTitle' and count(parameter)=0]"
			[Register ("getStatusBarTitle", "()Ljava/lang/String;", "GetGetStatusBarTitleHandler")]
			get {
				if (id_getStatusBarTitle == IntPtr.Zero)
					id_getStatusBarTitle = JNIEnv.GetMethodID (class_ref, "getStatusBarTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStatusBarTitle), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='setStatusBarTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatusBarTitle", "(Ljava/lang/String;)V", "GetSetStatusBarTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setStatusBarTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatusBarTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatusBarTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setStatusBarTitle_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='notifyUser' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("notifyUser", "(Landroid/content/Intent;Landroid/content/Context;ILjava/lang/String;)V", "")]
		protected override void NotifyUser (global::Android.Content.Intent p0, global::Android.Content.Context p1, int p2, string p3)
		{
			if (id_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_ == IntPtr.Zero)
				id_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyUser", "(Landroid/content/Intent;Landroid/content/Context;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallVoidMethod  (Handle, id_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_remind;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='remind' and count(parameter)=0]"
		[Register ("remind", "()Z", "")]
		protected override bool Remind ()
		{
			if (id_remind == IntPtr.Zero)
				id_remind = JNIEnv.GetMethodID (class_ref, "remind", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_remind);
		}

		static IntPtr id_unNotifyUser_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='StatusBarStrategy']/method[@name='unNotifyUser' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unNotifyUser", "(Landroid/content/Context;)V", "")]
		protected override void UnNotifyUser (global::Android.Content.Context p0)
		{
			if (id_unNotifyUser_Landroid_content_Context_ == IntPtr.Zero)
				id_unNotifyUser_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "unNotifyUser", "(Landroid/content/Context;)V");
			JNIEnv.CallVoidMethod  (Handle, id_unNotifyUser_Landroid_content_Context_, new JValue (p0));
		}

	}
}
