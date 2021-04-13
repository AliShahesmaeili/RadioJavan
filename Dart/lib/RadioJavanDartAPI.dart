/// Support for doing something awesome.
///
/// More dartdocs go here.
library RadioJavanDartAPI;

import 'dart:convert';

import 'package:http/http.dart';
import 'src/Classes/Helper/UriCreator.dart';
import 'src/Classes/Models/RadioJavanForgotPassword.dart';
import 'src/Classes/Models/RadioJavanLogin.dart';
import 'src/Classes/Models/RadioJavanRegister.dart';
import 'src/Classes/Result.dart';
export 'src/RadioJavanDartAPI_base.dart';

Future<IResult<RadioJavanLogin>> LoginAsync(
    String username, String password) async {
  try {
    var jsonData = {
      'login_email': username,
      'login_password': password,
    };
    var response = await post(UriCreator.GetLoginUri(), body: jsonData);
    return ResultAPI.Success(
        RadioJavanLogin.fromJson(jsonDecode(response.body)));
  } catch (e) {
    return ResultAPI.Fail(e.toString());
  }
}

Future<IResult<RadioJavanForgotPassword>> ForgotPasswordAsync(
    String email) async {
  try {
    var jsonData = {'email': email};
    var response =
        await post(UriCreator.GetForgotPasswordUri(), body: jsonData);
    return ResultAPI.Success(
        RadioJavanForgotPassword.fromJson(jsonDecode(response.body)));
  } catch (e) {
    return ResultAPI.Fail(e.toString());
  }
}

Future<IResult<RadioJavanRegister>> RegisterAsync(
    String email,
    String emailConfirm,
    String firstname,
    String lastname,
    String username,
    String password) async {
  try {
    var jsonData = {
      'email': email,
      'email_confirm': emailConfirm,
      'firstname': firstname,
      'lastname': lastname,
      'username': username,
      'password': password,
    };
    var response =
        await post(UriCreator.GetForgotPasswordUri(), body: jsonData);
    return ResultAPI.Success(
        RadioJavanRegister.fromJson(jsonDecode(response.body)));
  } catch (e) {
    return ResultAPI.Fail(e.toString());
  }
}
