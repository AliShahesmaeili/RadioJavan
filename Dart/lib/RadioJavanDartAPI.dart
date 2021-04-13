/// Support for doing something awesome.
///
/// More dartdocs go here.
library RadioJavanDartAPI;

import 'dart:convert';

import 'package:http/http.dart';
import 'src/Classes/Helper/UriCreator.dart';
import 'src/Classes/Models/RadioJavanLogin.dart';
import 'src/Classes/Result.dart';
export 'src/RadioJavanDartAPI_base.dart';

String url = 'https://r-j-app-desk.com/api2/login';

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
