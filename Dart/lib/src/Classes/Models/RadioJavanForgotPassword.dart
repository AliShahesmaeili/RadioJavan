class RadioJavanForgotPassword {
  bool Success;

  RadioJavanForgotPassword.fromJson(Map<String, dynamic> json)
      : Success = json['success'];
}
