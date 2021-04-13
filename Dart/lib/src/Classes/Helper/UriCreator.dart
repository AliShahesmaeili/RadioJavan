import 'package:RadioJavanDartAPI/src/API/RadioJavanApiConstants.dart';

class UriCreator {
  static final Uri BaseRadioJavanUri =
      Uri.parse(RadioJavanApiConstants.RADIOJAVAN_URL);

  static Uri GetLoginUri() => Uri.parse(
      RadioJavanApiConstants.RADIOJAVAN_URL + RadioJavanApiConstants.LOGIN);

  static Uri GetForgotPasswordUri() => Uri.parse(
      RadioJavanApiConstants.RADIOJAVAN_URL + RadioJavanApiConstants.FORGOT);

  static Uri GetRegisterUri() => Uri.parse(
      RadioJavanApiConstants.RADIOJAVAN_URL + RadioJavanApiConstants.REGISTER);
}
