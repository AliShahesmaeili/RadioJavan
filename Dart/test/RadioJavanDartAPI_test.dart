import 'package:RadioJavanDartAPI/RadioJavanDartAPI.dart';
import 'package:test/test.dart';

void main() {
  test('Should login', () async {
    var login = await LoginAsync('usernadme', 'password');
    expect(login.Succeeded, isTrue);
  });

  test('Should recovery password', () async {
    var forgot = await ForgotPasswordAsync('email');
    expect(forgot.Succeeded, isTrue);
  });

  test('Should register', () async {
    var register = await RegisterAsync(
        'email', 'confEmail', 'Ali', 'Shahesmaeili', 'alish', '123456789');
    expect(register.Succeeded, isTrue);
  });
}
