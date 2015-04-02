using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pushlink.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']"
	[global::Android.Runtime.Register ("com/pushlink/android/FriendlyPopUpStrategy", DoNotGenerateAcw=true)]
	public sealed partial class FriendlyPopUpStrategy : global::Com.Pushlink.Android.Strategy {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pushlink/android/FriendlyPopUpStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FriendlyPopUpStrategy); }
		}

		internal FriendlyPopUpStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getHash;
		static IntPtr id_setHash_Ljava_lang_String_;
		protected override string Hash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='getHash' and count(parameter)=0]"
			[Register ("getHash", "()Ljava/lang/String;", "GetGetHashHandler")]
			get {
				if (id_getHash == IntPtr.Zero)
					id_getHash = JNIEnv.GetMethodID (class_ref, "getHash", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHash), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='setHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHash", "(Ljava/lang/String;)V", "GetSetHash_Ljava_lang_String_Handler")]
			set {
				if (id_setHash_Ljava_lang_String_ == IntPtr.Zero)
					id_setHash_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHash", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setHash_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getNotNowButton;
		static IntPtr id_setNotNowButton_Ljava_lang_String_;
		public string NotNowButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='getNotNowButton' and count(parameter)=0]"
			[Register ("getNotNowButton", "()Ljava/lang/String;", "GetGetNotNowButtonHandler")]
			get {
				if (id_getNotNowButton == IntPtr.Zero)
					id_getNotNowButton = JNIEnv.GetMethodID (class_ref, "getNotNowButton", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNotNowButton), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='setNotNowButton' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotNowButton", "(Ljava/lang/String;)V", "GetSetNotNowButton_Ljava_lang_String_Handler")]
			set {
				if (id_setNotNowButton_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotNowButton_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotNowButton", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setNotNowButton_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getPopUpMessage;
		static IntPtr id_setPopUpMessage_Ljava_lang_String_;
		public string PopUpMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='getPopUpMessage' and count(parameter)=0]"
			[Register ("getPopUpMessage", "()Ljava/lang/String;", "GetGetPopUpMessageHandler")]
			get {
				if (id_getPopUpMessage == IntPtr.Zero)
					id_getPopUpMessage = JNIEnv.GetMethodID (class_ref, "getPopUpMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPopUpMessage), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='setPopUpMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPopUpMessage", "(Ljava/lang/String;)V", "GetSetPopUpMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setPopUpMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setPopUpMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPopUpMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setPopUpMessage_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getReminderTimeInSeconds;
		static IntPtr id_setReminderTimeInSeconds_Ljava_lang_Integer_;
		public global::Java.Lang.Integer ReminderTimeInSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='getReminderTimeInSeconds' and count(parameter)=0]"
			[Register ("getReminderTimeInSeconds", "()Ljava/lang/Integer;", "GetGetReminderTimeInSecondsHandler")]
			get {
				if (id_getReminderTimeInSeconds == IntPtr.Zero)
					id_getReminderTimeInSeconds = JNIEnv.GetMethodID (class_ref, "getReminderTimeInSeconds", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getReminderTimeInSeconds), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='setReminderTimeInSeconds' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setReminderTimeInSeconds", "(Ljava/lang/Integer;)V", "GetSetReminderTimeInSeconds_Ljava_lang_Integer_Handler")]
			set {
				if (id_setReminderTimeInSeconds_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setReminderTimeInSeconds_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setReminderTimeInSeconds", "(Ljava/lang/Integer;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setReminderTimeInSeconds_Ljava_lang_Integer_, new JValue (value));
			}
		}

		static IntPtr id_getUpdateButton;
		static IntPtr id_setUpdateButton_Ljava_lang_String_;
		public string UpdateButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='getUpdateButton' and count(parameter)=0]"
			[Register ("getUpdateButton", "()Ljava/lang/String;", "GetGetUpdateButtonHandler")]
			get {
				if (id_getUpdateButton == IntPtr.Zero)
					id_getUpdateButton = JNIEnv.GetMethodID (class_ref, "getUpdateButton", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUpdateButton), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='setUpdateButton' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUpdateButton", "(Ljava/lang/String;)V", "GetSetUpdateButton_Ljava_lang_String_Handler")]
			set {
				if (id_setUpdateButton_Ljava_lang_String_ == IntPtr.Zero)
					id_setUpdateButton_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUpdateButton", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setUpdateButton_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='notifyUser' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='remind' and count(parameter)=0]"
		[Register ("remind", "()Z", "")]
		protected override bool Remind ()
		{
			if (id_remind == IntPtr.Zero)
				id_remind = JNIEnv.GetMethodID (class_ref, "remind", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_remind);
		}

		static IntPtr id_unNotifyUser_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='FriendlyPopUpStrategy']/method[@name='unNotifyUser' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unNotifyUser", "(Landroid/content/Context;)V", "")]
		protected override void UnNotifyUser (global::Android.Content.Context p0)
		{
			if (id_unNotifyUser_Landroid_content_Context_ == IntPtr.Zero)
				id_unNotifyUser_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "unNotifyUser", "(Landroid/content/Context;)V");
			JNIEnv.CallVoidMethod  (Handle, id_unNotifyUser_Landroid_content_Context_, new JValue (p0));
		}

	}
}
