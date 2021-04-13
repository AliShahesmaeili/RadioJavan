class RadioJavanLogin {
  bool Success;
  String Redirect;
  String UserId;
  String Message;

  RadioJavanLogin.fromJson(Map<String, dynamic> json)
      : Success = json['success'],
        Redirect = json['redirect'],
        UserId = json['user_id'],
        Message = json['msg'];
}
