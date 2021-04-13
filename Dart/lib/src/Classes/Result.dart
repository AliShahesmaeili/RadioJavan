import 'ResultInfo.dart';

class Result<T> implements IResult<T> {
  Result(bool succeeded, T value, ResultInfo info) {
    Succeeded = succeeded;
    Value = value;
    Info = info;
  }

  Result.withoutValue(bool succeeded, ResultInfo info) {
    Succeeded = succeeded;
    Info = info;
  }

  Result.withoutResultInfo(bool succeeded, T value) {
    Succeeded = succeeded;
    Value = value;
  }

  @override
  ResultInfo Info;

  @override
  bool Succeeded;

  @override
  T Value;
}

abstract class IResult<T> {
  bool Succeeded;
  T Value;
  ResultInfo Info;
}

class ResultAPI {
  static IResult<T> Success<T>(T resValue) {
    return Result<T>(true, resValue, ResultInfo('No errors detected'));
  }

  static IResult<T> SuccessWithMessage<T>(String successMsg, T resValue) {
    return Result<T>(true, resValue, ResultInfo(successMsg));
  }

  static IResult<T> Fail<T>(String errMsg) {
    return Result<T>(false, null, ResultInfo(errMsg));
  }
}
