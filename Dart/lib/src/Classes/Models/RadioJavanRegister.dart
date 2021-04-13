class RadioJavanRegister {
  bool Success;
  String Redirect;
  String UserId;
  String Message;

  RadioJavanRegister.fromJson(Map<String, dynamic> json)
      : Success = json['success'],
        Redirect = json['redirect'],
        UserId = json['user_id'],
        Message = json['msg'];
}
